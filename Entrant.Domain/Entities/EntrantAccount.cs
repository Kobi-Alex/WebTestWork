using System;
using System.Linq;
using System.Collections.Generic;


namespace Entrant.Domain.Entities
{
    public class EntrantAccount
    {
        // Account identity PK
        public int Id { get; set; }
        // Account name (unique)
        public string Name { get; set; }


        // Foreign Key
        public string EntrantIncedentName { get; set; }
        // Navigation property
        public virtual EntrantIncedent EntrantIncedent { get; set; } 
        //List of contacts
        public virtual ICollection<EntrantContact> EntrantContacts { get; set; }

    }
}
