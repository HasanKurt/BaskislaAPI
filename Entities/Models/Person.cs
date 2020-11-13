using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("persons")]
    public class Person
    {
        [Column("id")]
        public int id { get; set; }
        [Column("first_name")]
        [StringLength(60, ErrorMessage = "First Name can't be longer than 60 characters")]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(60, ErrorMessage = "Last Name can't be longer than 60 characters")]
        public string LastName { get; set; }
        [Column("father")]
        public int? father{ get; set; }
        [Column("mother")]
        public int? mother{ get; set; }
        [Column("is_living")]
        public bool? IsLiving { get; set; }
        [Column("gender")]
        public string Gender { get; set; }

    }
}
