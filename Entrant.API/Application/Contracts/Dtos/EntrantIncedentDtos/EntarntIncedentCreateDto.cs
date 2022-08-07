using System;
using System.ComponentModel.DataAnnotations;

namespace Entrant.API.Application.Contracts.Dtos.EntrantIncedentDtos
{
    public class EntrantIncedentCreateDto
    {
        [Required(ErrorMessage = "Incedent description is required")]
        public string Description { get; set; }
        public int EntrantAccountId { get; set; }
    }
}
