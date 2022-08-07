using System;

namespace Entrant.API.Application.Services.Interfaces
{
    public interface IServiceManager
    {
        IEntrantIncedentService EntrantIncedentService { get; } 
        IEntrantAccountService EntrantAccountService { get; } 
        IEntrantContactService EntrantContactService { get; } 
    }
}