using System;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using Entrant.Domain.Entities;
using Entrant.Domain.Repositories;
using Entrant.API.Application.Exceptions;
using Entrant.API.Application.Services.Interfaces;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;


namespace Entrant.API.Application.Services
{
    internal sealed class EntrantContactService : IEntrantContactService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repositoryManager;


        public EntrantContactService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }

        public async Task<bool> IsContactExistAsync(string email, CancellationToken cancellationToken = default)
        {
            var contact = await _repositoryManager.EntrantContactRepository.GetByEmailAsync(email, cancellationToken);

            if (contact is null)
            {
                return false;
            }
            
            return true;
        }

        public async Task<EntrantContactReadDto> CreateAsync(EntrantContactCreateDto contactCreateDto, CancellationToken cancellationToken = default)
        {
            if (contactCreateDto is null)
            {
                throw new ArgumentException(null, nameof(contactCreateDto));
            }

            var contact = _mapper.Map<EntrantContact>(contactCreateDto);
            _repositoryManager.EntrantContactRepository.Insert(contact);
            await _repositoryManager.UnitOfWork.SaveChangesAsync();

            var account = await _repositoryManager.EntrantAccountRepository.GetByNameAsync(contactCreateDto.AccountName, cancellationToken);
            account.EntrantContactId = contact.Id;

            var incident = _mapper.Map<EntrantIncedent>(contactCreateDto);
            incident.EntrantAccountId = account.Id;
            _repositoryManager.EntrantIncedentRepository.Insert(incident);
            await _repositoryManager.UnitOfWork.SaveChangesAsync();

            return _mapper.Map<EntrantContactReadDto>(contact);
        }

        public async Task UpdateAsync(EntrantContactCreateDto contactUpdateDto, CancellationToken cancellationToken = default)
        {
            if (contactUpdateDto is null)
            {
                throw new ArgumentException(nameof(contactUpdateDto));
            }

            var contact = await _repositoryManager.EntrantContactRepository
                .GetByEmailAsync(contactUpdateDto.Email);

            if (contact is null)
            {
                throw new ContactNotFoundException(contactUpdateDto.Email);
            }

            contact.FirstName = contactUpdateDto.FirstName;
            contact.LastName = contactUpdateDto.LastName;

            var account = await _repositoryManager.EntrantAccountRepository
                .GetByNameAsync(contactUpdateDto.AccountName, cancellationToken);

            account.EntrantContactId = contact.Id;

            await _repositoryManager.UnitOfWork.SaveChangesAsync();
        }
    }
}