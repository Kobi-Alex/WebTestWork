using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Entrant.Domain.Entities;


namespace Entrant.Domain.Repositories
{
    public interface IEntantIncedentRepository
    {
        Task<IEnumerable<EntrantIncedent>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<EntrantIncedent> GetByNameAsync(string name, CancellationToken cancellationToken = default);

        void Insert(EntrantIncedent item);
        void Remove(EntrantIncedent item);
    }
}
