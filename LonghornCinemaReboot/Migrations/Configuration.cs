namespace LonghornCinemaReboot.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LonghornCinemaReboot.DAL.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LonghornCinemaReboot.DAL.AppDbContext context)
        {
            GenreData AddGenres = new GenreData();
            AddGenres.SeedGenre(context);

            RatingData AddRatings = new RatingData();
            AddRatings.SeedRatings(context);

            ActorData AddActors = new ActorData();
            AddActors.SeedActors(context);

            SeedIdentity Seed = new SeedIdentity();
            Seed.AddAdmin(context);

            //MovieData AddMovies = new MovieData();
            //AddMovies.SeedMovies(context);

            //SeedCustomers seedCustomers = new SeedCustomers();
            //seedCustomers.AddCustomers(context);

            SeedEmployees seedEmployees = new SeedEmployees();
            seedEmployees.AddEmployees(context);
        }
    }
}
