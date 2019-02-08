namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreInfoToOrderAndOrderDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderDetails", "ExtendedPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderDetails", "ExtendedPrice");
            DropColumn("dbo.OrderDetails", "ProductPrice");
        }
    }
}
