using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LonghornCinemaReboot.DAL;
using LonghornCinemaReboot.Models;
using Microsoft.AspNet.Identity;

namespace LonghornCinemaReboot.Controllers
{
    public enum Condition { Greater, Less }
    public class MovieController : Controller
    {
        //Create an instance of the db context
        AppDbContext db = new AppDbContext();
        
        // GET: Movie
        public ActionResult Index(String SearchString)
        {
            //Store total repo count in ViewBag
            ViewBag.MovieCount = db.Movies.ToList().Count();

            //Create list of repos containing list of customers to display on form
            List<Movie> SelectedMovies = new List<Movie>();

            //Use LINQ to filter wanted repos
            var query = from m in db.Movies
                        select m;

            //Check to see if SearchString is null. If null, display all; else, limit query to repos containing string in repo name or user name
            if (SearchString == null || SearchString == "")
            {
                //Do nothing, keep query as is
            }
            else
            {
                query = query.Where(m => m.Title.Contains(SearchString));
            }

            //Use .ToList() method to execute query
            SelectedMovies = query.ToList();

            //Add total repo count and selected repo count
            ViewBag.TotalMovies = db.Movies.Count();
            ViewBag.SelectedMovies = SelectedMovies.Count();

            //Send SelectedRepositories to the view
            return View(SelectedMovies.OrderBy(m => m.Title));
        }


        // GET: Movies/Create
        public ActionResult Create()
        {
            ViewBag.AllMPAASL = GetAllMPAASL();
            ViewBag.AllGenres = GetAllGenres();
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int SelectedMPAA, int[] SelectedGenres, [Bind(Include = "MovieID,MovieNumber,Title,Overview,Actors,Tagline,RunTime,ReleaseDate")] Movie movie)
        {
            //Find next registration number
            movie.MovieNumber = Utilities.GenerateNextMovieNumber.GetNextMovieNumber();


            if (SelectedGenres == null)
            {
                return RedirectToAction("Create", "Movie");
            }
            MPAA mpaa = db.MPAA.Find(SelectedMPAA);
            movie.MPAA = mpaa;

            //Check if genre was selected
            if (SelectedGenres != null)
            {
                bool first = true;

                //Iterate through list
                foreach (int i in SelectedGenres)
                {
                    Genre gen = db.Genres.Find(i);
                    //If first, trim original query, then switch flag
                    if (first)
                    {
                        movie.Genres.Add(gen);
                        first = false;
                    }

                    //Find union of original trimmed query and second trimmed query
                    else
                    {
                        movie.Genres.Add(gen);
                    }
                }
            }

            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AllMPAASL = GetAllMPAASL();
            ViewBag.AllGenres = GetAllGenres();
            return View(movie);
        }
        

        //Retrieve movie details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        public ActionResult DateSearchResults()
        {
            List<Showing> SelectedMovies = new List<Showing>();

            var query = from s in db.Showings
                        select s;

            SelectedMovies = query.ToList();

            ViewBag.TotalShowings = db.Showings.Count();
            ViewBag.SelectedMovies = SelectedMovies.Count();

            return View(SelectedMovies.OrderBy(s => s.StartTime));
        }

        public ActionResult DateSearch()
        {
            return View();
        }

        public ActionResult DisplayShowingSearchResults(DateTime? datSelectedDate)
        {
            //Create list of showings to display on form
            List<Showing> SelectedMovies = new List<Showing>();

            //Use LINQ to filter wanted showings
            var query = from s in db.Showings
                        select s;

            ////Determine date
            if (datSelectedDate != null)
            {
                //Convert date to non-nullable type
                DateTime datSelected = datSelectedDate ?? new DateTime(1900, 1, 1);
                query = query.Where(s => s.StartTime.Equals(datSelected));
            }
            else
            {
                //Do nothing, keep query as is
            }

            //Use .ToList() method to execute query
            SelectedMovies = query.ToList();

            //Add total movie count and selected movie count
            ViewBag.TotalShowings = db.Showings.Count();
            ViewBag.SelectedShowings = SelectedMovies.Count();

            //Send SelectedRepositories to the view
            return View("~/Views/Movie/DateSearchResults.cshtml", SelectedMovies.OrderBy(s => s.StartTime));

        }

        public ActionResult MovieSearch()
        {

            ViewBag.AllGenres = GetAllGenres();
            ViewBag.AllActors = GetAllActors();
            ViewBag.AllMPAA = GetAllMPAAs();
            return View();
        }

        public ActionResult DisplaySearchResults(String strSearchTitle, String strSearchTagline, int[] SelectedGenres, DateTime? datSelectedDate, int[] SelectedMPAA, String strRating, Condition enumSelectedCondition, String strSearchActor)
        {
            //Create list of movies to display on form
            List<Movie> SelectedMovies = new List<Movie>();

            //Use LINQ to filter wanted movies
            var query = from m in db.Movies
                        select m;

            //Check if strSearchTitle is null; else limit query to movies containing string in title
            if (strSearchTitle != null && strSearchTitle != "")
            {
                query = query.Where(m => m.Title.Contains(strSearchTitle));
            }

            //Check if strSearchTagline is null; else limit query to movies containing string in tagline
            if (strSearchTagline != null && strSearchTitle != "")
            {
                query = query.Where(m => m.Tagline.Contains(strSearchTagline));
            }

            //Check if genre was selected
            if (SelectedGenres != null)
            {
                bool first = true;

                //Create second query to filter from
                var q2 = query;

                //Iterate through list
                foreach (int i in SelectedGenres)
                {
                    //If first, trim original query, then switch flag
                    if (first)
                    {
                        query = query.Where(m => m.Genres.Any(g => g.GenreID == i));
                        first = false;
                    }
                    
                    //Find union of original trimmed query and second trimmed query
                    else
                    {
                        query = query.Union(q2.Where(m => m.Genres.Any(g => g.GenreID == i)));
                    }                  
                }
            }

            //Determine date
            if (datSelectedDate != null)
            {
                //Convert date to non-nullable type
                DateTime datSelected = datSelectedDate ?? new DateTime(1900, 1, 1);
                query = query.Where(m => m.ReleaseDate.Equals(datSelected) || m.ReleaseDate >= datSelected);
            }
            else
            {
                //Do nothing, keep query as is
            }

            //Check if MPAA was selected
            if (SelectedMPAA != null)
            {
                bool first = true;

                //Create second query to filter from
                var q2 = query;

                //Iterate through list
                foreach (int i in SelectedMPAA)
                {
                    //If first, trim original query, then switch flag
                    if (first)
                    {
                        query = query.Where(m => m.MPAA.MPAAID == i);
                        first = false;
                    }

                    //Find union of original trimmed query and second trimmed query
                    else
                    {
                        query = query.Union(q2.Where(m => m.MPAA.MPAAID == i));
                    }
                }
            }

            //See if they specified something for stars
            if (strRating != null && strRating != "")
            //Make sure string is a valid number
            {
                Decimal decRating;
                try
                {
                    decRating = Convert.ToDecimal(strRating);
                }
                catch //This code will display when something is wrong
                {
                    //Add a message for the viewbag
                    ViewBag.Message = "You must enter a number to search by stars";

                    //Re-populate dropdown
                    ViewBag.AllGenres = GetAllGenres();
                    ViewBag.AllActors = GetAllActors();
                    ViewBag.AllMPAA = GetAllMPAAs();

                    //Send user back to home page
                    return View("MovieSearch");
                }

                //Filter for star count
                if (enumSelectedCondition == Condition.Greater)
                {
                    query = query.Where(r => r.CustomerRating.Equals(decRating) || r.CustomerRating >= decRating);
                }
                else if (enumSelectedCondition == Condition.Less)
                {
                    query = query.Where(r => r.CustomerRating.Equals(decRating) || r.CustomerRating <= decRating);
                }
            }
            else
            {
                //Do nothing, keep query as is
            }

            //Check if Actor was selected
            if (strSearchActor != null && strSearchActor != "")
            {
                bool first = true;

                //Create second query to filter from
                var q2 = query;

                Char delimiter = ',';
                String[] Actors = strSearchActor.Split(delimiter);
                foreach (var substring in Actors)
                {
                    String name = null;

                    if (substring[0] == ' ')
                    {
                        name = substring.Substring(1);
                    }
                    else
                    {
                        name = substring;
                    }

                    if (first)
                    {
                        query = query.Where(m => m.Actors.Contains(name));
                        first = false;
                    }

                    else
                    {
                        query = query.Union(q2.Where(m => m.Actors.Contains(name)));
                    }
                }
            }

            //Use .ToList() method to execute query
            SelectedMovies = query.ToList();

            //Add total movie count and selected movie count
            ViewBag.TotalMovies = db.Movies.Count();
            ViewBag.SelectedMovies = SelectedMovies.Count();

            //Send SelectedRepositories to the view
            return View("~/Views/Movie/Index.cshtml",SelectedMovies.OrderBy(m => m.Title));

        }

        [Authorize(Roles = "Customer")]
        public ActionResult AddReview(Int32 MovieID)
        {
            //Create new instance of order detail class
            Review r = new Review();

            //Find order for this order detail
            Movie mov = db.Movies.Find(MovieID);

            //Set new order detail's order to the new ord we just found
            r.Movie = mov;

            //Give view the order detail object we just created
            return View(r);
        }

        // POST: Orders/AddToOrder
        [HttpPost]
        [Authorize]
        public ActionResult AddReview(Review r)
        {
            //Find order associated with the order detail
            Movie mov = db.Movies.Find(r.Movie.MovieID);

            //Set property of the order detail to this newly found order
            r.Movie = mov;

            r.Votes = 0;

            AppUser user = db.Users.Find(User.Identity.GetUserId());
            r.AppUser = user;

            //Int32 movieCount = user.OrderDetails.Where(o => o.Movie.MovieID == r.Movie.MovieID).Count();

            if (user.Reviews.Where(u => u.Movie.MovieID == r.Movie.MovieID).Count() == 0)
            {
                db.Reviews.Add(r);
                db.SaveChanges();
                return RedirectToAction("Details", "Movie", new { id = mov.MovieID });
            }


            else
            {
                ViewBag.MultipleReviewMessage = "You have already submitted a review for this movie";
                return View(r);
            }

        }

        public ActionResult MovieCheckout()
        {
            return View();
        }

        public MultiSelectList GetAllActors()
        {
            List<Actor> allActors = db.Actors.OrderBy(a => a.ActorName).ToList() ;

            MultiSelectList selActors = new MultiSelectList(allActors, "ActorID", "ActorName");

            return selActors;
        }

        public MultiSelectList GetAllGenres()
        {
            List<Genre> allGenres = db.Genres.OrderBy(g => g.GenreName).ToList();

            MultiSelectList selGenres = new MultiSelectList(allGenres, "GenreID", "GenreName");

            return selGenres;
        }

        public MultiSelectList GetAllGenres(Movie movie)
        {
            List<Genre> allGenres = db.Genres.OrderBy(g => g.GenreName).ToList();

            //Convert list of selected genres to ints
            List<Int32> SelectedGenres = new List<Int32>();

            //Loop through the movie's genres and add the genre ID
            foreach (Genre gen in movie.Genres)
            {
                SelectedGenres.Add(gen.GenreID);
            }

            //Create the multiselect list
            MultiSelectList selGenres = new MultiSelectList(allGenres, "ActorID", "ActorName", SelectedGenres);

            //Return the multiselect list
            return selGenres;
        }

        public MultiSelectList GetAllMPAAs()
        {
            List<MPAA> allMPAAs = db.MPAA.OrderBy(r => r.MPAAName).ToList();

            MultiSelectList selMPAAs = new MultiSelectList(allMPAAs, "MPAAID", "MPAAName");

            return selMPAAs;
        }

        //method to get all Movies for the ViewBag
        public SelectList GetAllMPAASL()
        {
            //Get the list of courses in order by course name
            List<MPAA> allMPAA = db.MPAA.OrderBy(c => c.MPAAName).ToList();

            //convert the list to a select list
            SelectList selMPAA = new SelectList(allMPAA, "MPAAID", "MPAAName");

            //return the select list
            return selMPAA;
        }
    }
}
