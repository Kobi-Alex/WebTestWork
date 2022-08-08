using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos;


namespace Entrant.API.Application.Services.Interfaces
{
    public interface IEntrantAccountService
    {
        Task<EntrantAccountReadDto> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<EntrantAccountReadDto> CreateAsync(EntrantAccountCreateDto accountCreateDto, CancellationToken cancellationToken = default);
    }
}
