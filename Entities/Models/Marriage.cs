using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("marriages")]
    public class Marriage
    {
        public int MarriageId { get; set; }

        public int male { get; set; }
        public int female { get; set; }
    }
}
