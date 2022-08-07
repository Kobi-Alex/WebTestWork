using System;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.Domain.Repositories;
using Entrant.API.Application.Services.Interfaces;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;
using Entrant.API.Application.Exceptions;
using Entrant.Domain.Entities;

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

        public async Task<EntrantContactReadDto> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            var contact = await _repositoryManager.EntrantContactRepository.GetByEmailAsync(email, cancellationToken);

            if (contact is null)
            {
                throw new ContactNotFoundException(email);
            }

            var contactDto = _mapper.Map<EntrantContactReadDto>(contact);

            return contactDto;
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

            return _mapper.Map<EntrantContactReadDto>(contact);
        }



        public Task UpdateAsync(string email, EntrantContactUpdateDto contactUpdateDto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}