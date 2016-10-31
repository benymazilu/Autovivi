using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public class AutoviviDbContext :DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Add> Adds { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Map(m =>
            {
                m.ToTable("Users");
            });

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Autovivi.Models.User> Users { get; set; }
    }
}