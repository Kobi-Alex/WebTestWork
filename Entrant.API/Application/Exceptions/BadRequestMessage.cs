using System;

namespace Entrant.API.Application.Exceptions
{
    public class BadRequestMessage : BadRequestException
    {
        public BadRequestMessage(string message)
            : base(message)
        {
        }
    }
}
