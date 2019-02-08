namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewsDBUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "AppUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Reviews", "AppUser_Id");
            AddForeignKey("dbo.Reviews", "AppUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "AppUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Reviews", new[] { "AppUser_Id" });
            DropColumn("dbo.Reviews", "AppUser_Id");
        }
    }
}
