using System.Collections.Generic;
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
            context.Users.AddOrUpdate(
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "al@gmail.com",
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    UserName = "al@gmail.com"
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
            context.Categories.AddOrUpdate(

                new Category { Name = "Cars" },
                new Category { Name = "Trucks" }
            );

            context.Products.AddOrUpdate(
                new Product
                {
                    Name = "Mazda", Descriptions = "Mazda 1993", CategoryId = 1, IsDeleted = false,
                    Price = (decimal)99.6, Count = 1
                }
                );
            context.SaveChanges();
        }
    }
}
