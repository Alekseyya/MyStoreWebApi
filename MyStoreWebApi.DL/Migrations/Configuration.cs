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
                    UserName = "Al",
                    FirstName = "YAsia",
                    LastName = "Frontender",
                    Age = 19,
                    Gender = "Man"
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
                    UserName = "la2",
                    FirstName = "Gena",
                    LastName = "Turbo",
                    Age = 27,
                    Gender = "Woman"
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

            context.Pictures.AddOrUpdate(
                    new Picture
                    {
                        Name = "Scania 730",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Scania S 730 v8.jpg",
                        ProductId = 1
                    },
                    new Picture
                    {
                        Name = "Mazda 6",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Mazda 6.jpg",
                        ProductId = 2
                    },
                    new Picture
                    {
                        Name = "BMW X6",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\BMW X6.jpg",
                        ProductId = 3
                    },
                    new Picture
                    {
                        Name = "BMW X6 compartment",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\BMW X6 comportment.png",
                        ProductId = 4
                    },
                    new Picture
                    {
                        Name = "BMW I8",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\BMW i8.jpg",
                        ProductId = 5
                    },
                    new Picture
                    {
                        Name = "BMW 7 vi",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\BMW 7 vi.jpg",
                        ProductId = 6
                    },
                    new Picture
                    {
                        Name = "Acura ZDX",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Acura ZDX.jpg",
                        ProductId = 7
                    },
                    new Picture
                    {
                        Name = "Acura ILX",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Acura ILX.png",
                        ProductId = 8
                    },
                    new Picture
                    {
                        Name = "Acura MDX 2",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Acura MDX 2.jpg",
                        ProductId = 9
                    },
                    new Picture
                    {
                        Name = "Acura NSX 2",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Acura NSX 2.jpg",
                        ProductId = 10
                    },
                    new Picture
                    {
                        Name = "Opel Agam",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Opel Agam.jpg",
                        ProductId = 11
                    },
                    new Picture
                    {
                        Name = "Opel Antara",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Opel Antara.jpg",
                        ProductId = 12
                    },
                    new Picture
                    {
                        Name = "Opel Speedster",
                        UpdateTimestamp = DateTime.Today,
                        Path = @"C:\Work\Andersen\MyStoreWebApi\Images\Opel Speedster.jpg",
                        ProductId = 13
                    }
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
                    Name = "X6",
                    Descriptions = "2009-2014",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 2,
                    Name = "X6 compartment 3",
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
                    Name = "i8",
                    Descriptions = "2014-2017",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 4,
                    Name = "7 vi",
                    Descriptions = "2014-2017",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
            new Product
            {
                MarkId = 1,
                Name = "ZDX",
                Descriptions = "2004-2013",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
            new Product
            {
                MarkId = 1,
                Name = "ILX",
                Descriptions = "2016-2017",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
                new Product
                {
                    MarkId = 1,
                    Name = "MDX 2",
                    Descriptions = "2013-2015",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },
                new Product
                {
                    MarkId = 1,
                    Name = "NSX 2",
                    Descriptions = "2003-2005",
                    CategoryId = 1,
                    IsDeleted = false,
                    Price = (decimal)140.6,
                    Count = 1
                },

            new Product
            {
                MarkId = 31,
                Name = "Agam",
                Descriptions = "2005-2007",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
            new Product
            {
                MarkId = 31,
                Name = "Antara",
                Descriptions = "2008-2010",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            },
            new Product
            {
                MarkId = 31,
                Name = "Speedster",
                Descriptions = "2003-2009",
                CategoryId = 1,
                IsDeleted = false,
                Price = (decimal)140.6,
                Count = 1
            });


            context.SaveChanges();
        }
    }
}
