using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrant.Domain.Entities
{
    public class EntrantContact
    {
        // Contact identity PK
        public string Email { get; set; }
        // Contact first name
        public string FirstName { get; set; }
        // Contact last name
        public string LastName { get; set; }

        // Foreign Key
        public string EntrantContactEmail { get; set; }
        // Navigation property
        public virtual EntrantAccount EntrantAccount { get; set; }
    }
}
