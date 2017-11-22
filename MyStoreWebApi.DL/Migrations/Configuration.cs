using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyStoreWebApi.DL.Context.MyStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyStoreWebApi.DL.Context.MyStoreContext context)
        {
            context.Users.AddOrUpdate(u => u.Id,
                new User
                {
                    Id = Guid.NewGuid(), Email = "al@gmail.com", EmailConfirmed = false,
                    PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = true,
                    AccessFailedCount = 0, UserName = "al@gmail.com"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "alek@gmail.com",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "alek@gmail.com"
                }
            );
            context.SaveChanges();
        }
    }
}
