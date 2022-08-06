using Entrant.Domain.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace Entrant.Infrastructure.Persistance.Repositories
{
    internal sealed class UnitOfWork : IUnitOfWork
    {
        private readonly EntrantDbContext _dbContext;

        public UnitOfWork(EntrantDbContext dbContext) => _dbContext = dbContext;

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            _dbContext.SaveChangesAsync(cancellationToken);
    }
}
