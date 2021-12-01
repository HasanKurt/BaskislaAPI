using CsvHelper;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class RepoConfiguration: IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            List<Person> recordsList;
            using (var reader = new StreamReader("..\\Entities\\SeedData\\baskisla214mockData.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                var records = csv.GetRecords<Person>();
                recordsList = records.ToList();
            }

            builder.ToTable("persons");
            builder.HasData(recordsList);
                //new Person
                //{
                //    FirstName = "Hasan",
                //    Gender = "M",
                //    id = 1,
                //    IsLiving = true,
                //    LastName = "Kurt"
                //});
        }
    }
}
