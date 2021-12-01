using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //https://code-maze.com/migrations-and-seed-data-efcore/
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using(var scope = host.Services.CreateScope())
            {
                using(var appContext = scope.ServiceProvider.GetRequiredService<RepositoryContext>())
                {
                    try { 
                        appContext.Database.Migrate(); 
                    }
                    catch {
                        throw;
                    }
                }
            }

            return host;
        }
    }
}
