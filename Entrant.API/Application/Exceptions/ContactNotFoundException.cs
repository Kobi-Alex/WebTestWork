using System;

namespace Entrant.API.Application.Exceptions
{
    public sealed class ContactNotFoundException : NotFoundException
    {
        public ContactNotFoundException(int Id)
            : base($"The contact with the identifier {Id} was not found")
        {
        }

        public ContactNotFoundException(string email)
           : base($"The contact with the email {email} was not found")
        {
        }
    }
}