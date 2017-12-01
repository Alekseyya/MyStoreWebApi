namespace MyStoreWebApi.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
        //    CreateTable(
        //        "dbo.Categories",
        //        c => new
        //            {
        //                Id = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false),
        //            })
        //        .PrimaryKey(t => t.Id);
            
        //    CreateTable(
        //        "dbo.Products",
        //        c => new
        //            {
        //                Id = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false, maxLength: 250),
        //                Descriptions = c.String(maxLength: 400),
        //                Price = c.Decimal(nullable: false, precision: 15, scale: 2),
        //                CategoryId = c.Int(),
        //                IsDeleted = c.Boolean(nullable: false),
        //                Count = c.Int(nullable: false),
        //                MarkId = c.Int(),
        //            })
        //        .PrimaryKey(t => t.Id)
        //        .ForeignKey("dbo.Marks", t => t.MarkId)
        //        .ForeignKey("dbo.Categories", t => t.CategoryId)
        //        .Index(t => t.CategoryId)
        //        .Index(t => t.MarkId);
            
        //    CreateTable(
        //        "dbo.Marks",
        //        c => new
        //            {
        //                Id = c.Int(nullable: false, identity: true),
        //                Name = c.String(nullable: false),
        //            })
        //        .PrimaryKey(t => t.Id);
            
        //    CreateTable(
        //        "dbo.Orders",
        //        c => new
        //            {
        //                Id = c.Int(nullable: false, identity: true),
        //                Quantity = c.Int(nullable: false),
        //                OrderPrice = c.Decimal(nullable: false, precision: 15, scale: 2),
        //                OrderDate = c.DateTime(nullable: false),
        //                User_Id = c.Guid(nullable: false),
        //                Product_Id = c.Int(),
        //            })
        //        .PrimaryKey(t => t.Id)
        //        .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
        //        .ForeignKey("dbo.Products", t => t.Product_Id)
        //        .Index(t => t.User_Id)
        //        .Index(t => t.Product_Id);
            
        //    CreateTable(
        //        "dbo.Users",
        //        c => new
        //            {
        //                Id = c.Guid(nullable: false, identity: true),
        //                FirstName = c.String(),
        //                LastName = c.String(),
        //                Age = c.Int(),
        //                Gender = c.String(),
        //                Email = c.String(),
        //                EmailConfirmed = c.Boolean(nullable: false),
        //                PasswordHash = c.String(),
        //                SecurityStamp = c.String(),
        //                PhoneNumber = c.String(),
        //                PhoneNumberConfirmed = c.Boolean(nullable: false),
        //                TwoFactorEnabled = c.Boolean(nullable: false),
        //                LockoutEndDateUtc = c.DateTime(),
        //                LockoutEnabled = c.Boolean(nullable: false),
        //                AccessFailedCount = c.Int(nullable: false),
        //                UserName = c.String(),
        //            })
        //        .PrimaryKey(t => t.Id);
            
        //    CreateTable(
        //        "dbo.Claims",
        //        c => new
        //            {
        //                Id = c.Int(nullable: false, identity: true),
        //                UserId = c.Guid(nullable: false),
        //                ClaimType = c.String(),
        //                ClaimValue = c.String(),
        //            })
        //        .PrimaryKey(t => t.Id)
        //        .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
        //        .Index(t => t.UserId);
            
        //    CreateTable(
        //        "dbo.Logins",
        //        c => new
        //            {
        //                UserId = c.Guid(nullable: false, identity: true),
        //                LoginProvider = c.String(),
        //                ProviderKey = c.String(),
        //                User_Id = c.Guid(),
        //            })
        //        .PrimaryKey(t => t.UserId)
        //        .ForeignKey("dbo.Users", t => t.User_Id)
        //        .Index(t => t.User_Id);
            
        //    CreateTable(
        //        "dbo.Roles",
        //        c => new
        //            {
        //                RoleId = c.Guid(nullable: false),
        //                UserId = c.Guid(nullable: false, identity: true),
        //                CustomRole_Id = c.Guid(),
        //            })
        //        .PrimaryKey(t => t.RoleId)
        //        .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
        //        .ForeignKey("dbo.CustomRoles", t => t.CustomRole_Id)
        //        .Index(t => t.UserId)
        //        .Index(t => t.CustomRole_Id);
            
        //    CreateTable(
        //        "dbo.Pictures",
        //        c => new
        //            {
        //                Id = c.Int(nullable: false, identity: true),
        //                Name = c.String(),
        //                Path = c.String(),
        //                UpdateTimestamp = c.DateTime(nullable: false),
        //                ProductId = c.Int(),
        //            })
        //        .PrimaryKey(t => t.Id)
        //        .ForeignKey("dbo.Products", t => t.ProductId)
        //        .Index(t => t.ProductId);
            
        //    CreateTable(
        //        "dbo.CustomRoles",
        //        c => new
        //            {
        //                Id = c.Guid(nullable: false),
        //                Name = c.String(),
        //            })
        //        .PrimaryKey(t => t.Id);
            
        //    CreateTable(
        //        "dbo.OrderProducts",
        //        c => new
        //            {
        //                OrderId = c.Int(nullable: false),
        //                ProductId = c.Int(nullable: false),
        //            })
        //        .PrimaryKey(t => new { t.OrderId, t.ProductId })
        //        .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
        //        .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
        //        .Index(t => t.OrderId)
        //        .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Roles", "CustomRole_Id", "dbo.CustomRoles");
            //DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            //DropForeignKey("dbo.Pictures", "ProductId", "dbo.Products");
            //DropForeignKey("dbo.Orders", "Product_Id", "dbo.Products");
            //DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            //DropForeignKey("dbo.Roles", "UserId", "dbo.Users");
            //DropForeignKey("dbo.Logins", "User_Id", "dbo.Users");
            //DropForeignKey("dbo.Claims", "UserId", "dbo.Users");
            //DropForeignKey("dbo.OrderProducts", "ProductId", "dbo.Products");
            //DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            //DropForeignKey("dbo.Products", "MarkId", "dbo.Marks");
            //DropIndex("dbo.OrderProducts", new[] { "ProductId" });
            //DropIndex("dbo.OrderProducts", new[] { "OrderId" });
            //DropIndex("dbo.Pictures", new[] { "ProductId" });
            //DropIndex("dbo.Roles", new[] { "CustomRole_Id" });
            //DropIndex("dbo.Roles", new[] { "UserId" });
            //DropIndex("dbo.Logins", new[] { "User_Id" });
            //DropIndex("dbo.Claims", new[] { "UserId" });
            //DropIndex("dbo.Orders", new[] { "Product_Id" });
            //DropIndex("dbo.Orders", new[] { "User_Id" });
            //DropIndex("dbo.Products", new[] { "MarkId" });
            //DropIndex("dbo.Products", new[] { "CategoryId" });
            //DropTable("dbo.OrderProducts");
            //DropTable("dbo.CustomRoles");
            //DropTable("dbo.Pictures");
            //DropTable("dbo.Roles");
            //DropTable("dbo.Logins");
            //DropTable("dbo.Claims");
            //DropTable("dbo.Users");
            //DropTable("dbo.Orders");
            //DropTable("dbo.Marks");
            //DropTable("dbo.Products");
            //DropTable("dbo.Categories");
        }
    }
}
