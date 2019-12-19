using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonForUpdateDto
    {
        //[Required(ErrorMessage = "Name is required")]
        //[StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
