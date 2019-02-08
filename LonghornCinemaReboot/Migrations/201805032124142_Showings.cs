namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Showings : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MovieGenres", newName: "GenreMovies");
            DropPrimaryKey("dbo.GenreMovies");
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        DateID = c.Int(nullable: false, identity: true),
                        DayStartTime = c.DateTime(nullable: false),
                        DayEndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DateID);
            
            CreateTable(
                "dbo.Showings",
                c => new
                    {
                        ShowingID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        TheaterID = c.Int(nullable: false),
                        SpecialEvent = c.Boolean(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        SelectedMovie_MovieID = c.Int(nullable: false),
                        Day_DateID = c.Int(),
                        Day_DateID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ShowingID)
                .ForeignKey("dbo.Movies", t => t.SelectedMovie_MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Days", t => t.Day_DateID)
                .ForeignKey("dbo.Days", t => t.Day_DateID1)
                .Index(t => t.SelectedMovie_MovieID)
                .Index(t => t.Day_DateID)
                .Index(t => t.Day_DateID1);
            
            AddPrimaryKey("dbo.GenreMovies", new[] { "Genre_GenreID", "Movie_MovieID" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Showings", "Day_DateID1", "dbo.Days");
            DropForeignKey("dbo.Showings", "Day_DateID", "dbo.Days");
            DropForeignKey("dbo.Showings", "SelectedMovie_MovieID", "dbo.Movies");
            DropIndex("dbo.Showings", new[] { "Day_DateID1" });
            DropIndex("dbo.Showings", new[] { "Day_DateID" });
            DropIndex("dbo.Showings", new[] { "SelectedMovie_MovieID" });
            DropPrimaryKey("dbo.GenreMovies");
            DropTable("dbo.Showings");
            DropTable("dbo.Days");
            AddPrimaryKey("dbo.GenreMovies", new[] { "Movie_MovieID", "Genre_GenreID" });
            RenameTable(name: "dbo.GenreMovies", newName: "MovieGenres");
        }
    }
}
