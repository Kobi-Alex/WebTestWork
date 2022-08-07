using System;
using System.Collections.Generic;


namespace Entrant.Domain.Entities
{
    public class EntrantContact
    {
        //Contact identity PK
        public int Id { get; set; }
        //Contact first name
        public string FirstName { get; set; }
        //Contact last name
        public string LastName { get; set; }
        //Contact email 
        public string Email { get; set; }

        //List of accounts
        public virtual ICollection<EntrantAccount> EntrantAccounts { get; set; }
    }
}
