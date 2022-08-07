using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.API.Application.Contracts.Dtos.EntrantIncedentDtos;


namespace Entrant.API.Application.Services.Interfaces
{
    public interface IEntrantIncedentService
    {
        Task<IEnumerable<EntrantIncedentReadDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<EntrantIncedentReadDto> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<EntrantIncedentReadDto> CreateAsync(EntrantIncedentCreateDto incedentCreateDto, CancellationToken cancellationToken = default);
        Task UpdateAsync(int answerId, EntrantIncedentUpdateDto incedentUpdateDto, CancellationToken cancellationToken = default);
    }
}