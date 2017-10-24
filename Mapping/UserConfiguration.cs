using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Entity.ModelConfiguration;

namespace Mapping
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
