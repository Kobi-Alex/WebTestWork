using System;
using System.Collections.Generic;


namespace Entrant.Domain.Entities
{
    public class EntrantContact
    {
        // Contact identity PK
        public int Id { get; set; }
        // Contact first name
        public string FirstName { get; set; }
        // Contact last name
        public string LastName { get; set; }
        // Contact email unique field
        public string Email { get; set; }

        // Foreign Key
        public string EntrantAccountEmail { get; set; }
        // Navigation property
        public virtual EntrantAccount EntrantAccount { get; set; }
    }
}
