using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using EFRemoveManyToManyDemo_ljy.Model;

namespace EFRemoveManyToManyDemo_ljy.Mapping
{
    public class RoleConfigurationMapping : EntityTypeConfiguration<Role>
    {
        public RoleConfigurationMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            HasMany(x => x.Users)
                .WithMany(x => x.Roles)
                .Map(m =>
                {
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("UserId");
                    m.ToTable("LNK_User_Role");
                });
        }
    }
}
