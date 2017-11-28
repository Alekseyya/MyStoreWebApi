using System;

namespace MyStoreWebApi.Api.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public string Password { get; set; }
        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }
    }
}