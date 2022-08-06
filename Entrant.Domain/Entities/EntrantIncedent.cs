using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Entrant.Domain.Entities
{
    public class EntrantIncedent
    {
        // Incedent identity PK
        public string Name { get; set; } = Guid.NewGuid().ToString();
        // Incedent description
        public string Description { get; set; }

        // List of account
        public virtual ICollection<EntrantAccount> EntrantAccounts { get; set; }

    }
}
