using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options, IConfiguration config)
            : base(options)
        {
            Configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("database"), b => b.MigrationsAssembly("BaskislaAPI"));
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Marriage> Marriages { get; set; }
        public IConfiguration Configuration { get; }
    }
}
