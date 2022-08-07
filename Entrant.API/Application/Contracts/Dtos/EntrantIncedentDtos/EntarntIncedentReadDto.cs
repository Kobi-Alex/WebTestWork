using System;
using Entrant.Domain.Entities;
using System.Collections.Generic;

namespace Entrant.API.Application.Contracts.Dtos.EntrantIncedentDtos
{
    public class EntrantIncedentReadDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int EntrantAccountId { get; set; }
    }
}
