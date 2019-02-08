namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class showings_two : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Showings", "TheaterID", "dbo.Theaters");
            DropIndex("dbo.Showings", new[] { "TheaterID" });
            AddColumn("dbo.AspNetUsers", "CreditCardOne", c => c.String());
            AddColumn("dbo.AspNetUsers", "CreditCardTwo", c => c.String());
            DropTable("dbo.Theaters");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Theaters",
                c => new
                    {
                        TheaterID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TheaterID);
            
            DropColumn("dbo.AspNetUsers", "CreditCardTwo");
            DropColumn("dbo.AspNetUsers", "CreditCardOne");
            CreateIndex("dbo.Showings", "TheaterID");
            AddForeignKey("dbo.Showings", "TheaterID", "dbo.Theaters", "TheaterID", cascadeDelete: true);
        }
    }
}
