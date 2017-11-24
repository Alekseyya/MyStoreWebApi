using System;
using System.Collections.Generic;

namespace MyStoreWebApi.BL.Models
{
    public class UserDTO
    {
       
        public virtual int AccessFailedCount { get; set; }
        
        public virtual ICollection<ClaimDTO> Claims { get; }
        
        public virtual string Email { get; set; }
       
        public virtual bool EmailConfirmed { get; set; }
        
        public virtual Guid Id { get; set; }
        
        public virtual bool LockoutEnabled { get; set; }
        
        public virtual DateTime? LockoutEndDateUtc { get; set; }
        
        public virtual ICollection<LoginDTO> Logins { get; }
       
        public virtual string PasswordHash { get; set; }
       
        public virtual string PhoneNumber { get; set; }
        
        public virtual bool PhoneNumberConfirmed { get; set; }
        
        public virtual ICollection<RoleDTO> Roles { get; }
        
        public virtual string SecurityStamp { get; set; }
        
        public virtual bool TwoFactorEnabled { get; set; }
        
        public virtual string UserName { get; set; }
    }
}
