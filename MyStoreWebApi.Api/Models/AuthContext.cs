using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyWebAPI.Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync
            (UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this,
                DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class AuthContext: IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("MyStore")
        {

        }
    }
}