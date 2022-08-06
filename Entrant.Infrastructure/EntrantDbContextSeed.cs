using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Entrant.Infrastructure
{
    public static class EntrantDbContextSeed
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<EntrantDbContext>());
            }
        }

        private static void SeedData(EntrantDbContext entrantDbContext)
        {
            throw new NotImplementedException();
        }
    }
}
