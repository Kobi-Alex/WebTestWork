using System;
using System.ComponentModel.DataAnnotations;

namespace Entrant.API.Application.Contracts.Dtos.EntrantContactDtos
{
    public class EntrantContactCreateDto
    {
        [Required(ErrorMessage = "Contact first name is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Contact last name is required")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Contact email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Account name is required")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

    }
}