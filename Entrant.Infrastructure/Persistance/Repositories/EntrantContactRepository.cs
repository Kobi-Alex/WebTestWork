using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Entrant.Domain.Entities;
using Entrant.Domain.Repositories;

using Microsoft.EntityFrameworkCore;


namespace Entrant.Infrastructure.Persistance.Repositories
{
    internal sealed class EntrantContactRepository : IEntrantContactRepository
    {
        private readonly EntrantDbContext _dbContext;
        public EntrantContactRepository(EntrantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get all contacts
        public async Task<IEnumerable<EntrantContact>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Contacts
                .ToListAsync(cancellationToken);
        }

        //Get all contacts by email
        public async Task<IEnumerable<EntrantContact>> GetAllContactByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Contacts
                .Where(c => c.EntrantAccountEmail == email)
                .ToListAsync(cancellationToken);
        }

        //Get contact by email
        public async Task<EntrantContact> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Contacts
                .FirstOrDefaultAsync(c => c.Email == email, cancellationToken);
        }

        //Insert contact
        public void Insert(EntrantContact item)
        {
            _dbContext.Contacts.Add(item);
        }

        //Remove contact
        public void Remove(EntrantContact item)
        {
            _dbContext.Contacts.Remove(item);
        }
    }
}
