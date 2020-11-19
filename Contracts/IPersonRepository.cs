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
        Task<PersonDetailsViewModel> GetPersonDetailsByIdAsync(int id);
        Task<int> GetSpouseAsync(int id, bool inputIsMale);
        Task<IEnumerable<Person>> GetAllChildrenAsync(int parent, bool inputIsMale);

        //Task<IEnumerable<Person>> GetAllPersons();
        //Task<Person> GetPersonById(int personId);
        //Task<string> GetWifeOfMale(int maleId);
        //Task<IEnumerable<Person>> GetAllChildren(int parent);

        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);


    }
}
