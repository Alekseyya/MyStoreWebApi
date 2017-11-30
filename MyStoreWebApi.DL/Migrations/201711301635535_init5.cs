namespace MyStoreWebApi.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String());
            AddColumn("dbo.Users", "Age", c => c.Int());
            AddColumn("dbo.Users", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "Age");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
        }
    }
}
