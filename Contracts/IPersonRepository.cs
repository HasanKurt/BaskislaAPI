using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        IEnumerable<Person> GetAllPersons();
        Person GetPersonById(int personId);

        string GetWifeOfMale(int maleId);

        IEnumerable<Person> GetAllChildren(int parent);

        void CreatePerson(Person person);

    }
}
