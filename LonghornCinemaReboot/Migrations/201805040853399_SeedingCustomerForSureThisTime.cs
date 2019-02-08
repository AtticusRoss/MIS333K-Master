namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingCustomerForSureThisTime : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Tickets", "Showing_ShowingID", "dbo.Showings");
            DropForeignKey("dbo.Tickets", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.Tickets", new[] { "Order_OrderID" });
            DropIndex("dbo.Tickets", new[] { "Showing_ShowingID" });
            DropIndex("dbo.Tickets", new[] { "Movie_MovieID" });
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExtendedPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Movie_MovieID = c.Int(),
                        Order_OrderID = c.Int(),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUser_Id)
                .Index(t => t.Movie_MovieID)
                .Index(t => t.Order_OrderID)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.Theaters",
                c => new
                    {
                        TheaterID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TheaterID);
            
            CreateIndex("dbo.Showings", "TheaterID");
            AddForeignKey("dbo.Showings", "TheaterID", "dbo.Theaters", "TheaterID", cascadeDelete: true);
            DropColumn("dbo.Showings", "Price");
            DropTable("dbo.Tickets");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        TicketPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Seat = c.String(),
                        Taken = c.Boolean(nullable: false),
                        Order_OrderID = c.Int(),
                        Showing_ShowingID = c.Int(),
                        Movie_MovieID = c.Int(),
                    })
                .PrimaryKey(t => t.TicketID);
            
            AddColumn("dbo.Showings", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Showings", "TheaterID", "dbo.Theaters");
            DropForeignKey("dbo.OrderDetails", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.OrderDetails", new[] { "AppUser_Id" });
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "Movie_MovieID" });
            DropIndex("dbo.Showings", new[] { "TheaterID" });
            DropTable("dbo.Theaters");
            DropTable("dbo.OrderDetails");
            CreateIndex("dbo.Tickets", "Movie_MovieID");
            CreateIndex("dbo.Tickets", "Showing_ShowingID");
            CreateIndex("dbo.Tickets", "Order_OrderID");
            AddForeignKey("dbo.Tickets", "Movie_MovieID", "dbo.Movies", "MovieID");
            AddForeignKey("dbo.Tickets", "Showing_ShowingID", "dbo.Showings", "ShowingID");
            AddForeignKey("dbo.Tickets", "Order_OrderID", "dbo.Orders", "OrderID");
        }
    }
}
