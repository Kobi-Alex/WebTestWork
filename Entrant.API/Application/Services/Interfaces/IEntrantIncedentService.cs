using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.API.Application.Contracts.Dtos.EntrantIncedentDtos;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;

namespace Entrant.API.Application.Services.Interfaces
{
    public interface IEntrantIncedentService
    {
        Task<EntrantIncedentReadDto> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<EntrantIncedentReadDto> CreateAsync(EntrantContactCreateDto incedentCreateDto, CancellationToken cancellationToken = default);
    }
}