using System;
using System.Collections.Generic;

namespace Entrant.Domain.Entities
{
    public class EntrantIncedent
    {
        // Incedent identity PK
        public string Name { get; set; } = Guid.NewGuid().ToString();
        // Incedent description
        public string Description { get; set; }

        //Foreign Key
        public int EntrantAccountId { get; set; }
        //Navigation property
        public virtual EntrantAccount EntrantAccount { get; set; }

    }
}
