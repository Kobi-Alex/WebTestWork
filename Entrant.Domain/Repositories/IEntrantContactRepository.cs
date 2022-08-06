using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entrant.Domain.Entities;


namespace Entrant.Domain.Repositories
{
    public interface IEntrantContactRepository
    {
        Task<IEnumerable<EntrantContact>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<EntrantContact>> GetAllContactByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<EntrantContact> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

        void Insert(EntrantContact item);
        void Remove(EntrantContact item);
    }
}
