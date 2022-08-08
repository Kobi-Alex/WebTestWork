using System;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using Entrant.Domain.Entities;
using System.Collections.Generic;
using Entrant.Domain.Repositories;
using Entrant.API.Application.Exceptions;
using Entrant.API.Application.Services.Interfaces;
using Entrant.API.Application.Contracts.Dtos.EntrantIncedentDtos;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;

namespace Entrant.API.Application.Services
{
    internal sealed class EntrantIncedentService : IEntrantIncedentService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repositoryManager;

        public EntrantIncedentService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }

        public async Task<EntrantIncedentReadDto> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            var incident = await _repositoryManager.EntrantIncedentRepository.GetByNameAsync(name, cancellationToken);
            
            if(incident is null)
            {
                throw new IncedentNotFoundException(name);
            }

            var incidentDto = _mapper.Map<EntrantIncedentReadDto>(incident);

            return incidentDto;
        }

        public async Task<EntrantIncedentReadDto> CreateAsync(EntrantContactCreateDto incedentCreateDto, CancellationToken cancellationToken = default)
        {
            if (incedentCreateDto is null)
            {
                throw new ArgumentException(null, nameof(incedentCreateDto));
            }

            var incident = _mapper.Map<EntrantIncedent>(incedentCreateDto);

            _repositoryManager.EntrantIncedentRepository.Insert(incident);

            await _repositoryManager.UnitOfWork.SaveChangesAsync();

            return _mapper.Map<EntrantIncedentReadDto>(incident);
        }


    }
}