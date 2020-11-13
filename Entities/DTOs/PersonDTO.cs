using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Father { get; set; }
        public int Mother { get; set; }
        public string Gender { get; set; }
        public bool IsLiving { get; set; } 


    }

    public class PersonDetailsDTO: PersonDTO
    {
        public int Spouse { get; set; }
        public IEnumerable<int> Children { get; set; }
        public IEnumerable<int> Siblings { get; set; }


    }
}
