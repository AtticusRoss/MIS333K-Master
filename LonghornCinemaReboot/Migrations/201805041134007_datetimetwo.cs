namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimetwo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Days", "DayStartTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Days", "DayEndTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Showings", "StartTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Showings", "EndTime", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Showings", "EndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Showings", "StartTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Days", "DayEndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Days", "DayStartTime", c => c.DateTime(nullable: false));
        }
    }
}
