using System;
using Entrant.Domain.Repositories;


namespace Entrant.Infrastructure.Persistance.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IEntrantIncedentRepository> _lazyEntrantIncedentRepository;
        private readonly Lazy<IEntrantAccountRepository> _lazyEntrantAccountRepository;
        private readonly Lazy<IEntrantContactRepository> _lazyEntrantContactRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;


        public RepositoryManager(EntrantDbContext dbContext)
        {
            _lazyEntrantIncedentRepository = new Lazy<IEntrantIncedentRepository>(() => new EntrantIncedentRepository(dbContext));
            _lazyEntrantAccountRepository = new Lazy<IEntrantAccountRepository>(() => new EntrantAccountRepository(dbContext));
            _lazyEntrantContactRepository = new Lazy<IEntrantContactRepository>(() => new EntrantContactRepository(dbContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
        }

        public IEntrantAccountRepository EntrantAccountRepository => _lazyEntrantAccountRepository.Value;
        public IEntrantContactRepository EntrantContactRepository => _lazyEntrantContactRepository.Value;
        public IEntrantIncedentRepository EntrantIncedentRepository => _lazyEntrantIncedentRepository.Value;
        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}
