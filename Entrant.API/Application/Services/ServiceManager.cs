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
            _lazyEntrantAccountService = new Lazy<IEntrantAccountService>(() => new EntrantAccountService(repositoryManager, mapper));
            _lazyEntrantIncedentService = new Lazy<IEntrantIncedentService>(() => new EntrantIncedentService(repositoryManager, mapper));
        }

        public IEntrantIncedentService EntrantIncedentService => _lazyEntrantIncedentService.Value;
        public IEntrantAccountService EntrantAccountService => _lazyEntrantAccountService.Value;
        public IEntrantContactService EntrantContactService => _lazyEntrantContactService.Value;
    }
}
