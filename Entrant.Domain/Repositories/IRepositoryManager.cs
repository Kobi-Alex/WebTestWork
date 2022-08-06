using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrant.Domain.Repositories
{
    public interface IRepositoryManager
    {
        IEntantAccountRepository EntrantAccountRepository { get; }
        IEntantContactRepository EntrantContactRepository { get; }
        IEntantIncedentRepository EntrantIncedentRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
