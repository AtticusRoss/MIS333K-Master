namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustRatingAvgUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "CustRating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Movies", "CustomerRating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "CustomerRating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Reviews", "CustRating", c => c.Int(nullable: false));
        }
    }
}
