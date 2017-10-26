using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration.Conventions;
using EFRemoveManyToManyDemo_ljy.Mapping;
using EFRemoveManyToManyDemo_ljy.Model;

namespace EFRemoveManyToManyDemo_ljy
{
    public class ManyToManyRemoveContext : DbContext
    {
        public ManyToManyRemoveContext() : base("ManyToManyRemoveContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new Mapping.UserConfigurationMapping());
            modelBuilder.Configurations.Add(new RoleConfigurationMapping());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<Person> Person { get; set; }

    }
}
