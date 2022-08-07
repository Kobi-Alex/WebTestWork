using System;

namespace Entrant.API.Application.Exceptions
{
    public sealed class AccountNotFoundException : NotFoundException
    {
        public AccountNotFoundException(int Id)
            : base($"The account with the identifier {Id} was not found")
        {
        }

        public AccountNotFoundException(string name)
           : base($"The account with the name {name} was not found")
        {
        }
    }
}