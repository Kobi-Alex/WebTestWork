using System;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.Domain.Entities;
using Entrant.Domain.Repositories;
using Entrant.API.Application.Exceptions;
using Entrant.API.Application.Services.Interfaces;
using Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos;


namespace Entrant.API.Application.Services
{
    internal sealed class EntrantAccountService : IEntrantAccountService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repositoryManager;

        public EntrantAccountService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }


        public async Task<EntrantAccountReadDto> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            var account = await _repositoryManager.EntrantAccountRepository.GetByNameAsync(name, cancellationToken);

            if (account is null)
            {
                throw new AccountNotFoundException(name);
            }

            var accountDto = _mapper.Map<EntrantAccountReadDto>(account);
            return accountDto;
        }

        public async Task<EntrantAccountReadDto> CreateAsync(EntrantAccountCreateDto accountCreateDto, CancellationToken cancellationToken = default)
        {
            if (accountCreateDto is null)
            {
                throw new ArgumentException(null, nameof(accountCreateDto));
            }

            var contact = await _repositoryManager.EntrantContactRepository
                .GetByIdAsync(accountCreateDto.EntrantContactId, cancellationToken);

            if (contact is null)
            {
                throw new AccountNotFoundException(accountCreateDto.EntrantContactId);
            }

            var account = _mapper.Map<EntrantAccount>(accountCreateDto);
            _repositoryManager.EntrantAccountRepository.Insert(account);

            await _repositoryManager.UnitOfWork.SaveChangesAsync();

            return _mapper.Map<EntrantAccountReadDto>(account);
        }
    }
}