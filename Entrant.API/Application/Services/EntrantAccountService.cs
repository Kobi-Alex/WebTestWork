using AutoMapper;
using Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos;
using Entrant.API.Application.Services.Interfaces;
using Entrant.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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


        public Task<EntrantAccountReadDto> CreateAsync(EntrantAccountCreateDto accountCreateDto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EntrantAccountReadDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<EntrantAccountReadDto> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<EntrantAccountReadDto> GetByNameIncludeIncedentAsync(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string name, EntrantAccountUpdateDto accountUpdateDto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}