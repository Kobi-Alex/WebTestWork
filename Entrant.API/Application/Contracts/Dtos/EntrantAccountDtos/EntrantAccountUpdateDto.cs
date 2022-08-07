using System;
using System.ComponentModel.DataAnnotations;

namespace Entrant.API.Application.Contracts.Dtos.EntrantAccountDtos
{
    public class EntrantAccountUpdateDto
    {
        [Required(ErrorMessage = "Account name is required")]
        public string Name { get; set; }
    }
}