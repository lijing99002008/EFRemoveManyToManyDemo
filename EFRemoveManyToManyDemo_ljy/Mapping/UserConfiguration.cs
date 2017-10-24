using EFRemoveManyToManyDemo_ljy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace EFRemoveManyToManyDemo_ljy.Mapping
{
    public class UserConfigurationMapping : EntityTypeConfiguration<User>
    {
        public UserConfigurationMapping()
        {
            Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            Property(x => x.LastName).HasMaxLength(50).IsRequired();
        }
    }
}
