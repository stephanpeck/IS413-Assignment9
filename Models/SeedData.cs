using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMate.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {

            MovieDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MovieDBContext>();

            //make sure the database is up to date with any migrations

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }


                //Save changes to the database
                context.SaveChanges();

            
        }
    }
}
