using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Repository
{
    public class MarriageRepository : RepositoryBase<Marriage>, IMarriageRepository
    {
        public MarriageRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
