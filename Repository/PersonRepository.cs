using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Person> GetAllPersons()
        {
            //return (from p in RepositoryContext.Persons orderby p.id select p).ToList();
            return  FindAll()
                .OrderBy(ow => ow.id)
                .ToList();
        }

        public Person GetPersonById(int personId)
        {
            return (from p in RepositoryContext.Persons where p.id == personId select p)
                .FirstOrDefault();//FindByCondition(person => person.id.Equals(personId)).FirstOrDefault();
        }

        public async Task<PersonDetailsViewModel> GetPersonDetailsByIdAsync(int personId)
        {
            //todo: hacky(?) way to combine persons and marriages
            //todo: investigate join and Include 
            var model = new PersonDetailsViewModel();
            var person = (from p in RepositoryContext.Persons where p.id == personId select p)
                .FirstOrDefault();
            if (person != null)
            {
                model.Id = person.id;
                model.Father = person.father;
                model.Mother = person.mother;
                model.FirstName = person.FirstName;
                model.LastName = person.LastName;
                model.IsLiving = person.IsLiving;
                model.Gender = person.Gender;

                var spouse = await GetSpouseAsync(personId, person.Gender.StartsWith('M'));
                var siblinfPersons = await GetAllPaternalSiblingsAsync(personId);

                List<int> childIds = new List<int>();
                var childPersons =  await GetAllChildrenAsync(personId, person.Gender.StartsWith('M'));
                foreach (var child in childPersons)
                    childIds.Add(child.id);
                model.Children = childIds;
                model.Siblings = siblinfPersons;
                model.Spouse =  spouse;
                //todo: use Include method to join Person and Marriage tables!
            }
            return model;//FindByCondition(person => person.id.Equals(personId)).FirstOrDefault();
        }

        public async Task<int> GetSpouseAsync(int id, bool inputIsMale)
        {
            if (inputIsMale)
            {
                int? wifeId = await (from m in RepositoryContext.Marriages where m.male == id select m.female).Cast<int?>().FirstOrDefaultAsync();
                if (wifeId.HasValue)
                {
                    return wifeId.Value;//(from p in RepositoryContext.Persons where p.id == wifeId select p.FirstName).FirstOrDefault();
                }
            }
            else
            {
                int? husdbandId = await (from m in RepositoryContext.Marriages where m.female == id select m.male).Cast<int?>().FirstOrDefaultAsync();
                if (husdbandId.HasValue)
                {
                    return husdbandId.Value;//(from p in RepositoryContext.Persons where p.id == wifeId select p.FirstName).FirstOrDefault();
                }
            }

            return 0;//todo: refactor this method, code duplication is there
        }

        public async Task<IEnumerable<Person>> GetAllChildrenAsync(int parent, bool inputIsMale)
        {
            if(inputIsMale)
                return await (from p in RepositoryContext.Persons where p.father == parent select p).ToListAsync();
            else
                return await (from p in RepositoryContext.Persons where p.mother == parent select p).ToListAsync();
        }

        public async Task<IEnumerable<int>> GetAllPaternalSiblingsAsync(int id)
        {
            //for now, only look at father
            var fatherId = await (from p in RepositoryContext.Persons where p.id == id select p.father).FirstOrDefaultAsync();
            return await (from p in RepositoryContext.Persons where (p.father != null && p.father == fatherId && p.id != id)  select p.id).ToListAsync();
        }

        public void CreatePerson(Person person)
        {
            Create(person);
        }

        public void UpdatePerson(Person person)
        {
            Update(person);
        }

        public void DeletePerson(Person person)
        {
            Delete(person);
        }

        public async Task<Person> GetPersonByIdAsync(int personId)
        {
            return await FindByCondition(person => person.id.Equals(personId)).FirstOrDefaultAsync();// (from p in RepositoryContext.Persons where p.id == personId select p)
                //.FirstOrDefault();//FindByCondition(person => person.id.Equals(personId)).FirstOrDefault();
        }

        //Task<IEnumerable<Person>> IPersonRepository.GetAllPersons()
        //{
        //    throw new NotImplementedException();
        //}

        //Task<Person> IPersonRepository.GetPersonById(int personId)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<string> IPersonRepository.GetWifeOfMale(int maleId)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<IEnumerable<Person>> IPersonRepository.GetAllChildren(int parent)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
