using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        IEnumerable<Person> GetAllPersons();
    }
}
