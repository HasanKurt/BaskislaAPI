using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{

    //this is a view model, no relation with a table!
    public class PersonDetailsViewModel
    {
        public int Id { get; set; }
        public int Spouse { get; set; }
        public IEnumerable<int> Children { get; set; }
        public IEnumerable<int> Siblings { get; set; }

    }
}
