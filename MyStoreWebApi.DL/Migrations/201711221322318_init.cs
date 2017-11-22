namespace MyStoreWebApi.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
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
            //    "dbo.Products",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 250),
            //            Descriptions = c.String(maxLength: 400),
            //            Price = c.Decimal(nullable: false, precision: 15, scale: 2),
            //            CategoryId = c.Int(),
            //            IsDeleted = c.Boolean(nullable: false),
            //            Count = c.Int(nullable: false),
            //            PhotoId = c.Int(),
            //            OrderId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Orders", t => t.OrderId)
            //    .ForeignKey("dbo.Photos", t => t.PhotoId)
            //    .ForeignKey("dbo.Categories", t => t.CategoryId)
            //    .Index(t => t.CategoryId)
            //    .Index(t => t.PhotoId)
            //    .Index(t => t.OrderId);
            
            //CreateTable(
            //    "dbo.Orders",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Quantity = c.Int(nullable: false),
            //            OrderPrice = c.Decimal(nullable: false, precision: 15, scale: 2),
            //            OrderDate = c.DateTime(nullable: false),
            //            User_Id = c.Guid(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
            //    .Index(t => t.User_Id);
            
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
            
            //CreateTable(
            //    "dbo.Photos",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Image = c.Binary(maxLength: 8000),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            //DropForeignKey("dbo.Products", "PhotoId", "dbo.Photos");
            //DropForeignKey("dbo.Products", "OrderId", "dbo.Orders");
            //DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            //DropIndex("dbo.Orders", new[] { "User_Id" });
            //DropIndex("dbo.Products", new[] { "OrderId" });
            //DropIndex("dbo.Products", new[] { "PhotoId" });
            //DropIndex("dbo.Products", new[] { "CategoryId" });
            //DropTable("dbo.Photos");
            //DropTable("dbo.Users");
            //DropTable("dbo.Orders");
            //DropTable("dbo.Products");
            //DropTable("dbo.Categories");
        }
    }
}
