using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IPersonRepository _owner;
        private IMarriageRepository _account;

        public IPersonRepository Person
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new PersonRepository(_repoContext);
                }

                return _owner;
            }
        }

        public IMarriageRepository Marriage
        {
            get
            {
                if (_account == null)
                {
                    _account = new MarriageRepository(_repoContext);
                }

                return _account;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}