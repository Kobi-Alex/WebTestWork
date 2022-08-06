using Entrant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entrant.Domain.Repositories
{
    public interface IEntantContactRepository
    {
        Task<IEnumerable<EntrantContact>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<EntrantContact>> GetAllByAccountIdAsync(int accountId, CancellationToken cancellationToken = default);
        Task<EntrantAccount> GetByIdAsync(int id, CancellationToken cancellationToken = default);

        void Insert(EntrantContact item);
        void Remove(EntrantContact item);
    }
}
