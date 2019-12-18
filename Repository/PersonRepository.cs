﻿using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public string GetWifeOfMale(int maleId)
        {
            int? wifeId = (from m in RepositoryContext.Marriages where m.male == maleId select m.female).Cast<int?>().FirstOrDefault();
            if(wifeId.HasValue)
            {
                return (from p in RepositoryContext.Persons where p.id == wifeId select p.FirstName).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<Person> GetAllChildren(int parent)
        {
            return (from p in RepositoryContext.Persons where p.father == parent || p.mother == parent select p).ToList();
        }

        public void CreatePerson(Person person)
        {
            Create(person);
        }
    }
}
