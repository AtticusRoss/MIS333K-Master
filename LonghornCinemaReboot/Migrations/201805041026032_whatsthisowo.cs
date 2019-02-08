namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class whatsthisowo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.OrderDetails", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "AppUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.OrderDetails", new[] { "Movie_MovieID" });
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "AppUser_Id" });
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
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .ForeignKey("dbo.Showings", t => t.Showing_ShowingID)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUser_Id)
                .Index(t => t.Order_OrderID)
                .Index(t => t.Showing_ShowingID)
                .Index(t => t.AppUser_Id);
            
            DropTable("dbo.OrderDetails");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.OrderDetailID);
            
            DropForeignKey("dbo.Tickets", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tickets", "Showing_ShowingID", "dbo.Showings");
            DropForeignKey("dbo.Tickets", "Order_OrderID", "dbo.Orders");
            DropIndex("dbo.Tickets", new[] { "AppUser_Id" });
            DropIndex("dbo.Tickets", new[] { "Showing_ShowingID" });
            DropIndex("dbo.Tickets", new[] { "Order_OrderID" });
            DropTable("dbo.Tickets");
            CreateIndex("dbo.OrderDetails", "AppUser_Id");
            CreateIndex("dbo.OrderDetails", "Order_OrderID");
            CreateIndex("dbo.OrderDetails", "Movie_MovieID");
            AddForeignKey("dbo.OrderDetails", "AppUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.OrderDetails", "Order_OrderID", "dbo.Orders", "OrderID");
            AddForeignKey("dbo.OrderDetails", "Movie_MovieID", "dbo.Movies", "MovieID");
        }
    }
}
