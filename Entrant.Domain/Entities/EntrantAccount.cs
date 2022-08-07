using System;
using System.Linq;
using System.Collections.Generic;


namespace Entrant.Domain.Entities
{
    public class EntrantAccount
    {
        //Account identity PK
        public int Id { get; set; }
        //Account name (unique)
        public string Name { get; set; }

        //Foreign Key
        public int EntrantContactId { get; set; }
        //Navigation property
        public virtual EntrantContact EntrantContact { get; set; } 
        //List of incidents
        public virtual ICollection<EntrantIncedent> EntrantIncedents { get; set; }

    }
}
