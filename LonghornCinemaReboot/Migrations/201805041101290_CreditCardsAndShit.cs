namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditCardsAndShit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CreditCardOne");
            DropColumn("dbo.AspNetUsers", "CreditCardTwo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "CreditCardTwo", c => c.String());
            AddColumn("dbo.AspNetUsers", "CreditCardOne", c => c.String());
        }
    }
}
