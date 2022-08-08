using System;
using System.ComponentModel.DataAnnotations;

namespace Entrant.API.Application.Contracts.Dtos.EntrantContactDtos
{
    public class EntrantContactUpdateDto
    {
        [Required(ErrorMessage = "Contact first name is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Contact last name is required")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Contact email is required")]
        public string Email { get; set; }
    }
}