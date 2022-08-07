using AutoMapper;
using Entrant.API.Application.Services.Interfaces;
using Entrant.Domain.Repositories;
using System;

namespace Entrant.API.Application.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IEntrantContactService> _lazyEntrantContactService;
        private readonly Lazy<IEntrantAccountService> _lazyEntrantAccountService;
        private readonly Lazy<IEntrantIncedentService> _lazyEntrantIncedentService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper )
        {
            _lazyEntrantContactService = new Lazy<IEntrantContactService>(() => new EntrantContactService(repositoryManager, mapper));
        }

        public IEntrantIncedentService EntrantIncedentService => throw new NotImplementedException();
        public IEntrantAccountService EntrantAccountService => throw new NotImplementedException();
        public IEntrantContactService EntrantContactService => throw new NotImplementedException();
    }
}
