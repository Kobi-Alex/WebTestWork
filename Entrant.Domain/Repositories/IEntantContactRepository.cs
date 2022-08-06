using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.Domain.Entities;


namespace Entrant.Domain.Repositories
{
    public interface IEntantContactRepository
    {
        Task<IEnumerable<EntrantContact>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<EntrantContact>> GetAllEmailAccountIdAsync(string email, CancellationToken cancellationToken = default);
        Task<EntrantAccount> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

        void Insert(EntrantContact item);
        void Remove(EntrantContact item);
    }
}
