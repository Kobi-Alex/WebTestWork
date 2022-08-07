using System;
using System.ComponentModel.DataAnnotations;

namespace Entrant.API.Application.Contracts.Dtos.EntrantContactDtos
{
    public class EntrantContactCreateDto
    {
        [Required(ErrorMessage = "Contact first name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Contact first name can't be longer than 100 characters " +
            "and less than 3 characters")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Contact last name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Contact first name can't be longer than 100 characters " +
            "and less than 3 characters")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Contact email is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Contact first name can't be longer than 60 characters " +
            "and less than 3 characters")]
        public string Email { get; set; }
    }
}