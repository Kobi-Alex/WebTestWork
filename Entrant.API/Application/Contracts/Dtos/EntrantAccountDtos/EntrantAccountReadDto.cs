using System;
using System.Collections.Generic;
using Entrant.Domain.Entities;

namespace Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos
{
    public class EntrantAccountReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EntrantIncedentName { get; set; }
        public virtual EntrantIncedent EntrantIncedent { get; set; }
        public virtual ICollection<EntrantContact> EntrantContacts { get; set; }
    }
}

