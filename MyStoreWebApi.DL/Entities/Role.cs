using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyStoreWebApi.DL.Entities
{
    public class Role : IdentityUserRole<Guid> { }

    public class CustomRole : IdentityRole<Guid, Role>
    {
        public CustomRole() { }
        public CustomRole(string name) { Name = name; }
    }
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            Property(x => x.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
        }
    }
}
