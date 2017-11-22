namespace MyStoreWebApi.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Categories",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Orders",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.Int(nullable: false),
            //            ProductId = c.Int(nullable: false),
            //            Quantity = c.Int(nullable: false),
            //            OrderPrice = c.Decimal(nullable: false, precision: 15, scale: 2),
            //            OrderDate = c.DateTime(nullable: false),
            //            User_Id = c.Guid(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
            //    .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
            //    .Index(t => t.ProductId)
            //    .Index(t => t.User_Id);
            
            //CreateTable(
            //    "dbo.Products",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 250),
            //            Descriptions = c.String(maxLength: 400),
            //            Price = c.Decimal(nullable: false, precision: 15, scale: 2),
            //            CategoryId = c.Int(nullable: false),
            //            IsDeleted = c.Boolean(nullable: false),
            //            Count = c.Int(nullable: false),
            //            PhotoId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
            //    .ForeignKey("dbo.Photos", t => t.PhotoId, cascadeDelete: true)
            //    .Index(t => t.CategoryId)
            //    .Index(t => t.PhotoId);
            
            //CreateTable(
            //    "dbo.Photos",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Image = c.Binary(maxLength: 8000),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Users",
            //    c => new
            //        {
            //            Id = c.Guid(nullable: false, identity: true),
            //            Email = c.String(maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            //DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            //DropForeignKey("dbo.Products", "PhotoId", "dbo.Photos");
            //DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            //DropIndex("dbo.Products", new[] { "PhotoId" });
            //DropIndex("dbo.Products", new[] { "CategoryId" });
            //DropIndex("dbo.Orders", new[] { "User_Id" });
            //DropIndex("dbo.Orders", new[] { "ProductId" });
            //DropTable("dbo.Users");
            //DropTable("dbo.Photos");
            //DropTable("dbo.Products");
            //DropTable("dbo.Orders");
            //DropTable("dbo.Categories");
        }
    }
}
