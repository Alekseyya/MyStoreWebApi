using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyStoreWebApi.DL.Entities
{
    public class User
    {

        public Guid Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
    }
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(256)
                .IsOptional();

            Property(x => x.PasswordHash)
                .IsOptional();

            Property(x => x.PhoneNumber)
                .IsOptional();

            Property(x => x.SecurityStamp)
                .IsOptional();

            Property(x => x.LockoutEndDateUtc)
                .IsOptional();

            Property(x => x.AccessFailedCount)
                .IsRequired();

            Property(x => x.UserName)
                .HasMaxLength(256)
                .IsRequired();
        }
    }
}
