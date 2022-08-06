using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.Domain.Entities;

namespace Entrant.Domain.Repositories
{
    public interface IEntantAccountRepository
    {
        Task<IEnumerable<EntrantAccount>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<EntrantAccount> GetByNameAsync(string name, CancellationToken cancellationToken = default);
        Task<EntrantAccount> GetByNameIncludeContactAsync(string name, CancellationToken cancellationToken = default);
      
        void Insert(EntrantAccount item);
        void Remove(EntrantAccount item);
    }
}
