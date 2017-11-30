using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.BL.Models
{
    public class UserDTO 
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }

    }
}
