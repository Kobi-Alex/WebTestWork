using System;
using System.Collections.Generic;
using Entrant.Domain.Entities;

namespace Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos
{
    public class EntrantAccountReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EntrantContactId { get; set; }
        public ICollection<EntrantIncedent> EntrantIncedents { get; set; }
    }
}

