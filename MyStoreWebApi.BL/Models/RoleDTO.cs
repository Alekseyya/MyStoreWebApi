using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyStoreWebApi.BL.Models
{
    public class RoleDTO : IdentityRole<Guid, IdentityUserRole<Guid>>
    {
    }
}
