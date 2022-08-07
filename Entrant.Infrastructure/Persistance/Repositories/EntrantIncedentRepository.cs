using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Entrant.Domain.Repositories;
using Entrant.Domain.Entities;

using Microsoft.EntityFrameworkCore;


namespace Entrant.Infrastructure.Persistance.Repositories
{
    internal sealed class EntrantIncedentRepository : IEntrantIncedentRepository
    {
        private readonly EntrantDbContext _dbContext;

        public EntrantIncedentRepository(EntrantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get all incedents
        public async Task<IEnumerable<EntrantIncedent>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.Incedents
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        //Get incedent by name
        public async Task<EntrantIncedent> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _dbContext.Incedents
                .FirstOrDefaultAsync(i => i.Name == name, cancellationToken);
        }

        //Insert incedent
        public void Insert(EntrantIncedent item)
        {
            _dbContext.Incedents.Add(item);
        }

        //Incedent remove
        public void Remove(EntrantIncedent item)
        {
            _dbContext.Incedents.Remove(item);
        }
    }
}
