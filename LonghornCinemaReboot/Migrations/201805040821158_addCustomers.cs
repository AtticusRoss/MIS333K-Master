namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "PopcornPoints", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "CustomerNumber", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "SSN", c => c.Long(nullable: false));
            AddColumn("dbo.AspNetUsers", "MiddleInitial", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MiddleInitial");
            DropColumn("dbo.AspNetUsers", "SSN");
            DropColumn("dbo.AspNetUsers", "CustomerNumber");
            DropColumn("dbo.AspNetUsers", "PopcornPoints");
            DropColumn("dbo.AspNetUsers", "ZipCode");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "City");
        }
    }
}
