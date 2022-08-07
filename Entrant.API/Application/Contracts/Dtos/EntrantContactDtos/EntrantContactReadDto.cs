using System;
using Entrant.Domain.Entities;
using System.Collections.Generic;


namespace Entrant.API.Application.Contracts.Dtos.EntrantContactDtos
{
    public class EntrantContactReadDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<EntrantAccount> EntrantAccounts { get; set; }
    }
}
