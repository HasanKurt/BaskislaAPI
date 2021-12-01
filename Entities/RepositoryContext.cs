using Entities.Configuration;
using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : IdentityDbContext<User>
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RepoConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        //migrations
        //C:\Users\Eigenaar\Desktop\project\BaskislaAPI\BaskislaAPI>dotnet ef database update -> Create a DB in SQLEXPRESS with tables
        //dotnet ef database drop -> Drop it
        //dotnet ef migrations add WithMe -> Make a new migration called WithMe
        //dotnet ef database update -> Apply that migration (which also includes seed data)


        public DbSet<Person> Persons { get; set; }
        public DbSet<Marriage> Marriages { get; set; }
        public IConfiguration Configuration { get; }
    }
}
