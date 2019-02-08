namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieTheaterNavChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TheaterMovies", "Theater_TheaterID", "dbo.Theaters");
            DropForeignKey("dbo.TheaterMovies", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.TheaterMovies", new[] { "Theater_TheaterID" });
            DropIndex("dbo.TheaterMovies", new[] { "Movie_MovieID" });
            CreateIndex("dbo.Showings", "TheaterID");
            AddForeignKey("dbo.Showings", "TheaterID", "dbo.Theaters", "TheaterID", cascadeDelete: true);
            DropTable("dbo.TheaterMovies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TheaterMovies",
                c => new
                    {
                        Theater_TheaterID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Theater_TheaterID, t.Movie_MovieID });
            
            DropForeignKey("dbo.Showings", "TheaterID", "dbo.Theaters");
            DropIndex("dbo.Showings", new[] { "TheaterID" });
            CreateIndex("dbo.TheaterMovies", "Movie_MovieID");
            CreateIndex("dbo.TheaterMovies", "Theater_TheaterID");
            AddForeignKey("dbo.TheaterMovies", "Movie_MovieID", "dbo.Movies", "MovieID", cascadeDelete: true);
            AddForeignKey("dbo.TheaterMovies", "Theater_TheaterID", "dbo.Theaters", "TheaterID", cascadeDelete: true);
        }
    }
}
