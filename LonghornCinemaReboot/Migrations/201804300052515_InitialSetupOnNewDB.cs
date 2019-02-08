namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetupOnNewDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorID = c.Int(nullable: false, identity: true),
                        ActorName = c.String(),
                    })
                .PrimaryKey(t => t.ActorID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Overview = c.String(nullable: false),
                        Actors = c.String(nullable: false),
                        Tagline = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        CustomerRating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Revenue = c.Long(nullable: false),
                        RunTime = c.Int(nullable: false),
                        MPAA_MPAAID = c.Int(),
                    })
                .PrimaryKey(t => t.MovieID)
                .ForeignKey("dbo.MPAAs", t => t.MPAA_MPAAID)
                .Index(t => t.MPAA_MPAAID);
            
            CreateTable(
                "dbo.MPAAs",
                c => new
                    {
                        MPAAID = c.Int(nullable: false, identity: true),
                        MPAAName = c.String(),
                    })
                .PrimaryKey(t => t.MPAAID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
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
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderNumber = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUser_Id)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        CustRating = c.Int(nullable: false),
                        TextReview = c.String(maxLength: 100),
                        Votes = c.Int(nullable: false),
                        Movie_MovieID = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID)
                .Index(t => t.Movie_MovieID);
            
            CreateTable(
                "dbo.Theaters",
                c => new
                    {
                        TheaterID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TheaterID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Movie_MovieID = c.Int(nullable: false),
                        Genre_GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieID, t.Genre_GenreID })
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .Index(t => t.Movie_MovieID)
                .Index(t => t.Genre_GenreID);
            
            CreateTable(
                "dbo.TheaterMovies",
                c => new
                    {
                        Theater_TheaterID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Theater_TheaterID, t.Movie_MovieID })
                .ForeignKey("dbo.Theaters", t => t.Theater_TheaterID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .Index(t => t.Theater_TheaterID)
                .Index(t => t.Movie_MovieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderDetails", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.TheaterMovies", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.TheaterMovies", "Theater_TheaterID", "dbo.Theaters");
            DropForeignKey("dbo.Reviews", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.OrderDetails", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.Movies", "MPAA_MPAAID", "dbo.MPAAs");
            DropForeignKey("dbo.MovieGenres", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.MovieGenres", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.TheaterMovies", new[] { "Movie_MovieID" });
            DropIndex("dbo.TheaterMovies", new[] { "Theater_TheaterID" });
            DropIndex("dbo.MovieGenres", new[] { "Genre_GenreID" });
            DropIndex("dbo.MovieGenres", new[] { "Movie_MovieID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Reviews", new[] { "Movie_MovieID" });
            DropIndex("dbo.Orders", new[] { "AppUser_Id" });
            DropIndex("dbo.OrderDetails", new[] { "AppUser_Id" });
            DropIndex("dbo.OrderDetails", new[] { "Order_OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "Movie_MovieID" });
            DropIndex("dbo.Movies", new[] { "MPAA_MPAAID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.TheaterMovies");
            DropTable("dbo.MovieGenres");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Theaters");
            DropTable("dbo.Reviews");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.MPAAs");
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Actors");
        }
    }
}
