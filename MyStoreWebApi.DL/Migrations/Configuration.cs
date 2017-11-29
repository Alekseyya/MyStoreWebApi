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
                    UserName = "Al"
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
                    UserName = "la2"
                }
            );

            context.Categories.AddOrUpdate(

                new Category { Name = "Cars" },
                new Category { Name = "Trucks" }
            );

            context.Marks.AddOrUpdate(
                new Mark { Name = "Acura" },
                new Mark { Name = "Alfa Romeo" },
                new Mark { Name = "Audi" },
                new Mark { Name = "BMW" },
                new Mark { Name = "Cadilac" },
                new Mark { Name = "Chery" },
                new Mark { Name = "Chevrolet" },
                new Mark { Name = "Chrysler" },
                new Mark { Name = "Citroen" },
                new Mark { Name = "Daewo" },


                new Mark { Name = "Dodge" },
                new Mark { Name = "Fiat" },
                new Mark { Name = "Ford" },
                new Mark { Name = "Ford USA" },
                new Mark { Name = "Geely" },
                new Mark { Name = "Great Wall" },
                new Mark { Name = "Honda" },
                new Mark { Name = "Hyndai" },
                new Mark { Name = "Infinity" },
                new Mark { Name = "Jaguar" },

                new Mark { Name = "Jeep" },
                new Mark { Name = "Kia" },
                new Mark { Name = "Land Rover" },
                new Mark { Name = "Lexus" },
                new Mark { Name = "Lifan" },
                new Mark { Name = "Mazda" },
                new Mark { Name = "Mercedes" },
                new Mark { Name = "MINI" },
                new Mark { Name = "Mitsubishi" },
                new Mark { Name = "Nisan" },

                new Mark { Name = "Opel" },
                new Mark { Name = "Peugeot" },
                new Mark { Name = "Pontiac" },
                new Mark { Name = "Porsche" },
                new Mark { Name = "Renault" },
                new Mark { Name = "Rover" },
                new Mark { Name = "Saab" },
                new Mark { Name = "Scania" },
                new Mark { Name = "Seat" },
                new Mark { Name = "Skoda" }
            );

            context.Products.AddOrUpdate(
                new Product
                {
                    MarkId = 38,
                    Name = "S 730 v8",
                    Descriptions = "1993 - 2007",
                    CategoryId = 2,
                    IsDeleted = false,
                    Price = (decimal)99.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 26,
                    Name = "Mazda 6",
                    Descriptions = "1993 - 2007",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)99.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 4,
                    Name = "BMW X6",
                    Descriptions = "2009-2014",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 2,
                    Name = "BMX 6 compartment 3",
                    Descriptions = "2000-2009",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                }
                ,
                new Product
                {
                    MarkId = 4,
                    Name = "BMW i8",
                    Descriptions = "2014-2017",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 4,
                    Name = "BMW7 vi",
                    Descriptions = "2014-2017",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
            new Product
            {
                MarkId = 1,
                Name = "Acura CSX",
                Descriptions = "2004-2013",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
            new Product
            {
                MarkId = 1,
                Name = "Acura ILX",
                Descriptions = "2016-2017",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
                new Product
                {
                    MarkId = 1,
                    Name = "Acura MDX 2",
                    Descriptions = "2013-2015",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 1,
                    Name = "Acura NSX 2",
                    Descriptions = "2003-2005",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },

            new Product
            {
                MarkId = 31,
                Name = "Opel Agan",
                Descriptions = "2005-2007",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
            new Product
            {
                MarkId = 31,
                Name = "Opel Antara",
                Descriptions = "2008-2010",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
            new Product
            {
                MarkId = 31,
                Name = "Opel Combo",
                Descriptions = "2003-2009",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            }
                );
            context.SaveChanges();
        }
    }
}
