using System;
using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Api.Models
{
    public class UserModel
    {
        [Required]
        [StringLength(25)]
        public string UserName { get; set; }

        [Required]
        [StringLength(40)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword{ get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Very long FirstName")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Very long LastName")]
        public string LastName { get; set; }

        [Required]
        [Range(13,99)]
        public int? Age { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
    }
}