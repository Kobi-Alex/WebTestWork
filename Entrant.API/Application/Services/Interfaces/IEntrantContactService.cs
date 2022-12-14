using System;
using System.Threading;
using System.Threading.Tasks;
using Entrant.API.Application.Contracts.Dtos.EntrantContactDtos;


namespace Entrant.API.Application.Services.Interfaces
{
    public interface IEntrantContactService
    {
        Task<bool> IsContactExistAsync(string email, CancellationToken cancellationToken = default);
        Task<EntrantContactReadDto> CreateAsync(EntrantContactCreateDto contactCreateDto, CancellationToken cancellationToken = default);
        Task UpdateAsync(EntrantContactCreateDto contactCreateDto, CancellationToken cancellationToken = default);
    }
}
