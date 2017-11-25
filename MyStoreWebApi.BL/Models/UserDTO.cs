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

    }
}
