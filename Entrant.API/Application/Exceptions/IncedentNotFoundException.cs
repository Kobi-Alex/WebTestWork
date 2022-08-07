using System;

namespace Entrant.API.Application.Exceptions
{
    public sealed class IncedentNotFoundException : NotFoundException
    {

        public IncedentNotFoundException(string name)
            : base($"The incedent with the name {name} was not found")
        {
        }
    }
}
