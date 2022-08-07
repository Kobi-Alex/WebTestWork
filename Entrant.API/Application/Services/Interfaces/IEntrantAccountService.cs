using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos;


namespace Entrant.API.Application.Services.Interfaces
{
    public interface IEntrantAccountService
    {
        Task<IEnumerable<EntrantAccountReadDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<EntrantAccountReadDto> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<EntrantAccountReadDto> GetByNameIncludeIncedentAsync(string name, CancellationToken cancellationToken = default);
        Task<EntrantAccountReadDto> CreateAsync(EntrantAccountCreateDto accountCreateDto, CancellationToken cancellationToken = default);
        Task UpdateAsync(string name, EntrantAccountUpdateDto accountUpdateDto, CancellationToken cancellationToken = default);
    }
}
