using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entrant.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
