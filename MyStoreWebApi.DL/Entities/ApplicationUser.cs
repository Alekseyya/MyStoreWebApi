using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyStoreWebApi.DL.Context;

namespace MyStoreWebApi.DL.Entities
{

    //public class CustomUserStore : UserStore<ApplicationUser, CustomRole, Guid,
    //    Login, Role, Claim>
    //{
    //    public CustomUserStore(MyStoreContext context)
    //        : base(context)
    //    {
    //    }
    //}

    //public class CustomRoleStore : RoleStore<CustomRole, Guid, Role>
    //{
    //    public CustomRoleStore(MyStoreContext context)
    //        : base(context)
    //    {
    //    }
    //}

    //public class ApplicationUser : IdentityUser<Guid, Login, Role,
    //    Claim>
    //{
    //    //public async Task<ClaimsIdentity> GenerateUserIdentityAsync
    //    //    (UserManager<ApplicationUser, Guid> manager)
    //    //{
    //    //    var userIdentity = await manager.CreateIdentityAsync(this,
    //    //        DefaultAuthenticationTypes.ApplicationCookie);
    //    //    return userIdentity;
    //    //}
    //}
    
}
