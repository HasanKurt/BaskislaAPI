using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        IEnumerable<Person> GetAllPersons();
        Person GetPersonById (int personId);
        Task<Person> GetPersonByIdAsync(int personId);
        PersonDetailsViewModel GetPersonDetailsById(int id);
        int GetSpouse(int id);
        IEnumerable<Person> GetAllChildren(int parent);

        //Task<IEnumerable<Person>> GetAllPersons();
        //Task<Person> GetPersonById(int personId);
        //Task<string> GetWifeOfMale(int maleId);
        //Task<IEnumerable<Person>> GetAllChildren(int parent);

        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);


    }
}
