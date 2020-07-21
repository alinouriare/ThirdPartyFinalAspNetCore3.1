using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreNewFeature.Model
{
   public class PersonContext:DbContext
    {

        public DbSet<Person> People { get; set; }

        public DbSet<Address> Addresses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=.;initial catalog=EFCoreNewFeature;integrated security=true;")
                    .AddInterceptors(new HintCommandInterceptor());
        }
    }
}
