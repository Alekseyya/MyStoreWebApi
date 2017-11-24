using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyStoreWebApi.DL.Context;

namespace MyStoreWebApi.DL.Entities
{
   public class CustomUserStore : UserStore<User, CustomRole, Guid,
            Login, Role, Claim>
        {
            public CustomUserStore(MyStoreContext context)
                : base(context)
            {
            }
        }

        public class CustomRoleStore : RoleStore<CustomRole, Guid, Role>
        {
            public CustomRoleStore(MyStoreContext context)
                : base(context)
            {
            }
        }

    public class User : IdentityUser<Guid, Login, Role,
            Claim>
    {
            //public async Task<ClaimsIdentity> GenerateUserIdentityAsync
            //    (UserManager<ApplicationUser, Guid> manager)
            //{
            //    var userIdentity = await manager.CreateIdentityAsync(this,
            //        DefaultAuthenticationTypes.ApplicationCookie);
            //    return userIdentity;
            //}
        }
       
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
        }
    }
}
