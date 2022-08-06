using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

using Entrant.Domain.Entities;
using Entrant.Domain.Repositories;

using Microsoft.EntityFrameworkCore;


namespace Entrant.Infrastructure.Persistance.Repositories
{
    internal sealed class EntrantAccountRepository : IEntrantAccountRepository
    {
        private readonly EntrantDbContext _dbContext;
        public EntrantAccountRepository(EntrantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get all accounts
        public async Task<IEnumerable<EntrantAccount>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Accounts
                .ToListAsync(cancellationToken);
        }

        //Get account by name
        public async Task<EntrantAccount> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Accounts
                .FirstOrDefaultAsync(a => a.Name == name, cancellationToken);
        }

        //Get account by name include contact
        public async Task<EntrantAccount> GetByNameIncludeContactAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Accounts
                .Include(a => a.EntrantContacts)
                .FirstOrDefaultAsync(a => a.Name == name, cancellationToken);
        }

        //Insert account
        public void Insert(EntrantAccount item)
        {
            _dbContext.Accounts.Add(item);
        }

        //Check if account exists
        public bool IsAccountExists(string name)
        {
            return _dbContext.Accounts.Any(a => a.Name == name);
        }

        // Remove current account
        public void Remove(EntrantAccount item)
        {
            _dbContext.Accounts.Remove(item);
        }
    }
}
