using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;


namespace Entrant.API.Application.Services.Interfaces
{
    public interface IEntrantContactService
    {
        Task<IEnumerable<EntrantContactReadDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<EntrantContactReadDto> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<EntrantContactReadDto> CreateAsync(EntrantContactCreateDto contactCreateDto, CancellationToken cancellationToken = default);
        Task UpdateAsync(string email, EntrantContactUpdateDto contactUpdateDto, CancellationToken cancellationToken = default);
    }
}
