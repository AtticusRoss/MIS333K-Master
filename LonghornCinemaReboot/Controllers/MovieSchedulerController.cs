using LonghornCinemaReboot.DAL;
using LonghornCinemaReboot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using DHTMLX.Scheduler;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.IdentityModel.Metadata;

namespace LonghornCinemaReboot.Controllers
{


    public class MovieSchedulerController : Controller
    {
        //Create an instance of the db context
        AppDbContext db = new AppDbContext();
   


        // GET: MovieScheduler
        public ActionResult Index()
        {
            return View();

        }
        // POST: MovieScheduler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(String showing_date)
        {
            db.Configuration.ProxyCreationEnabled = false;

            DateTime selected_date;
            string pattern = "yyyy-MM-dd";
            DateTime.TryParseExact(showing_date, pattern, null, DateTimeStyles.None, out selected_date);

            if (selected_date < DateTime.Today)
            {
                return View();
            }
            else
            {
                var selected_day = db.Days.Where(o => o.DayStartTime.Day == selected_date.Day && o.DayStartTime.Month == selected_date.Month).FirstOrDefault();

                if (selected_day == null)
                {
                    Day created_day = new Day();
                    created_day.DayStartTime = new DateTime(selected_date.Year, selected_date.Month, selected_date.Day, 9, 0, 0);
                    created_day.DayEndTime = new DateTime(selected_date.Year, selected_date.Month, selected_date.Day, 23, 59, 59);
                    created_day.MoviesTheaterOne = new List<Showing>();
                    created_day.MoviesTheaterTwo = new List<Showing>();
                    db.Days.Add(created_day);
                    await db.SaveChangesAsync();

                    var day_to_return = db.Days.Where(o => o.DayStartTime.Day == selected_date.Day && o.DayStartTime.Month == selected_date.Month).FirstOrDefault();

                    return RedirectToAction("Details", new { id = day_to_return.DateID });
                }

                return RedirectToAction("Details", new { id = selected_day.DateID });
            }

        }

        // GET: MovieScheduler
        public ActionResult DayCopier(string date_to_copy, string date_to_overwrite)
        {
            db.Configuration.ProxyCreationEnabled = false;

            DateTime date_to_copy_parsed;
            DateTime date_to_overwrite_parsed;

            string pattern = "yyyy-MM-dd";
            DateTime.TryParseExact(date_to_copy, pattern, null, DateTimeStyles.None, out date_to_copy_parsed);
            DateTime.TryParseExact(date_to_overwrite, pattern, null, DateTimeStyles.None, out date_to_overwrite_parsed);

            if (date_to_overwrite_parsed < DateTime.Today)
            {
                return View();
            }
            else
            {
                var selection = db.Days.Where(o => o.DayStartTime.Day == date_to_copy_parsed.Day && o.DayStartTime.Month == date_to_copy_parsed.Month).FirstOrDefault();

                if (selection == null)
                {
                    return View();
                }
                else
                {
                    var day_overwrite = db.Days.Where(o => o.DayStartTime.Day == date_to_overwrite_parsed.Day && o.DayStartTime.Month == date_to_overwrite_parsed.Month).FirstOrDefault();

                    if (day_overwrite == null)
                    {
                        Day created_day = new Day();
                        created_day.DayStartTime = selection.DayStartTime;
                        created_day.DayEndTime = selection.DayEndTime;
                        created_day.MoviesTheaterOne = selection.MoviesTheaterOne;
                        created_day.MoviesTheaterTwo = selection.MoviesTheaterTwo;

                        db.Days.Add(created_day);
                        db.SaveChanges();
                        return RedirectToAction("Details", created_day.DateID);
                    }

                    db.Days.Remove(day_overwrite);

                    Day created_day2 = new Day();
                    created_day2.DayStartTime = selection.DayStartTime;
                    created_day2.DayEndTime = selection.DayEndTime;
                    created_day2.MoviesTheaterOne = selection.MoviesTheaterOne;
                    created_day2.MoviesTheaterTwo = selection.MoviesTheaterTwo;

                    db.Days.Add(created_day2);
                    db.SaveChanges();

                    return RedirectToAction("Details", created_day2.DateID);

                }
            }

        }

        // POST: DayCopier
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DayCopier(int? id)
        {
            db.Configuration.ProxyCreationEnabled = false;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showing selected_showing = db.Showings.Find(id);

            if (selected_showing == null)
            {
                return HttpNotFound();
            }
            String showing_movie_title = selected_showing.SelectedMovie.Title;
            db.Showings.Remove(selected_showing);
            db.SaveChanges();

            return RedirectToAction("RescheduleShowing", showing_movie_title);
        }


        // GET: MovieScheduler
        public ActionResult ShowingDetails(int? id)
        {
            AppDbContext db = new AppDbContext();

            db.Configuration.ProxyCreationEnabled = false;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showing selected_showing = db.Showings.Find(id);

            if (selected_showing == null)
            {
                return HttpNotFound();
            }
            return View(selected_showing);

        }

        // GET: MovieScheduler
        public ActionResult AddEvent()
        {
            return View();
        }

        // POST: MovieScheduler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddEvent(string movie, string theaterid, string specialevent, int starthour, int startminute, string ampm, string showing_date)
        {
            AppDbContext db = new AppDbContext();

            db.Configuration.ProxyCreationEnabled = false; 
            Movie mov = db.Movies.Where(o => o.Title == movie).FirstOrDefault();
            Int32 movid = mov.MovieID;

            if (mov == null)
            {
                return RedirectToAction("AddEvent");
            }

            DateTime parsedDate;
            string pattern = "yyyy-MM-dd";
            DateTime.TryParseExact(showing_date, pattern, null, DateTimeStyles.None, out parsedDate);

            if (ampm == "PM" && starthour != 12)
            {
                starthour = starthour + 12;
            }
            DateTime created_date = new DateTime(parsedDate.Year, parsedDate.Month, parsedDate.Day, starthour, startminute, 0);

            TimeSpan start = new TimeSpan(9, 0, 0); //9 o'clock
            TimeSpan end = new TimeSpan(23, 59, 59); //12 o'clock
            TimeSpan start_of_showing = created_date.TimeOfDay;
            DateTime ModelEndTime = (created_date.AddMinutes(mov.RunTime));
            TimeSpan end_of_showing = ModelEndTime.TimeOfDay;

            if (start_of_showing < start)
            {
                return RedirectToAction("AddEvent");
            }
            if (end_of_showing > end)
            {
                return RedirectToAction("AddEvent");
            }

            //get day info
            Day selected_day = db.Days.Where(o => o.DayStartTime.Day == created_date.Day && o.DayStartTime.Month == created_date.Month).FirstOrDefault();


            if (selected_day == null)
            {
                Day created_day = new Day();

                created_day.DayStartTime = new DateTime(created_date.Year, created_date.Month, created_date.Day, 9, 0, 0);
                created_day.DayEndTime = new DateTime(created_date.Year, created_date.Month, created_date.Day, 23, 59, 59);
                created_day.MoviesTheaterOne = new List<Showing>();
                created_day.MoviesTheaterTwo = new List<Showing>();

                db.Days.Add(created_day);

                await db.SaveChangesAsync();
            }


            Showing showing = new Showing();

            if (specialevent == "specialeventtrue")
            {
                showing.SpecialEvent = true;
            }
            else
            {
                showing.SpecialEvent = false;
            }

            Day new_selected_day = db.Days.Where(o => o.DayStartTime.Day == created_date.Day && o.DayStartTime.Month == created_date.Month).FirstOrDefault();


            if (theaterid == "TheaterOne")
            {
                showing.TheaterID = 1;
                if (new_selected_day.MoviesTheaterOne != null)
                { 
                    foreach (Showing movie_showing in new_selected_day.MoviesTheaterOne)
                    {
                        bool overlap = start_of_showing < (movie_showing.EndTime.TimeOfDay + new TimeSpan(0, 0, 25)) && (movie_showing.StartTime.TimeOfDay + new TimeSpan(0, 0, 25)) < end_of_showing;
                        if (overlap)
                        {
                            return RedirectToAction("AddEvent");
                        }
                    }
                }
            }
            else if (theaterid == "TheaterTwo")
            {
                showing.TheaterID = 2;
                if (new_selected_day.MoviesTheaterTwo != null) 
                {
                    foreach (Showing movie_showing in new_selected_day.MoviesTheaterTwo)
                    {
                        bool overlap = start_of_showing < (movie_showing.EndTime.TimeOfDay + new TimeSpan(0, 0, 25)) && (movie_showing.StartTime.TimeOfDay + new TimeSpan(0, 0, 25)) < end_of_showing;
                        if (overlap)
                        {
                            return RedirectToAction("AddEvent");
                        }
                    }
                }
            }
            else
            {
                return RedirectToAction("AddEvent");
            }

            Movie mov2 = db.Movies.Where(o => o.Title == movie).FirstOrDefault();
            Movie mov4;
            mov4 = db.Movies.Find(movid);

            Showing created_showing = new Showing();

            created_showing.SpecialEvent = showing.SpecialEvent;
            created_showing.SelectedMovie = mov4;
            created_showing.StartTime = created_date;
            created_showing.EndTime = ModelEndTime;
            created_showing.TheaterID = showing.TheaterID;
            List<String> seats = new List<string>();
            seats.Add("A1");
            seats.Add("A2");
            seats.Add("A3");
            seats.Add("A4");
            seats.Add("A5");
            seats.Add("A6");
            seats.Add("A7");
            seats.Add("A8");
            seats.Add("B1");
            seats.Add("B2");
            seats.Add("B3");
            seats.Add("B4");
            seats.Add("B5");
            seats.Add("B6");
            seats.Add("B7");
            seats.Add("B8");
            seats.Add("C1");
            seats.Add("C2");
            seats.Add("C3");
            seats.Add("C4");
            seats.Add("C5");
            seats.Add("C6");
            seats.Add("C7");
            seats.Add("C8");
            seats.Add("D1");
            seats.Add("D2");
            seats.Add("D3");
            seats.Add("D4");
            seats.Add("D5");
            seats.Add("D6");
            seats.Add("D7");
            seats.Add("D8");




            db.Showings.Add(created_showing);
            await db.SaveChangesAsync();



            foreach (String seat_string in seats)
            {

                Showing showing_last_selection3 = db.Showings.Where(o => o.StartTime == created_date && o.EndTime == ModelEndTime).FirstOrDefault();
                Showing showing_last_selection5 = db.Showings.Where(o => o.StartTime == created_date && o.EndTime == ModelEndTime).FirstOrDefault();

                Ticket t = new Ticket();
                t.TicketPrice = 12;
                t.Taken = false;
                t.Showing = showing_last_selection3;
                t.Seat = seat_string;
                t.Order = new Order();

                db.Tickets.Add(t);
                showing_last_selection3.Tickets.Add(t);
                db.Entry(showing_last_selection5).State = System.Data.Entity.EntityState.Modified;

                db.Entry(showing_last_selection5).CurrentValues.SetValues(showing_last_selection3);
                await db.SaveChangesAsync();
            }


            Showing showing_last_selection = db.Showings.Where(o => o.StartTime == created_date && o.EndTime == ModelEndTime).FirstOrDefault();
            Day new_selected_day3 = db.Days.Where(o => o.DayStartTime.Day == created_date.Day && o.DayStartTime.Month == created_date.Month).FirstOrDefault();
            Day new_selected_day6 = db.Days.Find(new_selected_day3.DateID);

            if (showing_last_selection.TheaterID == 1)
            {
                if (new_selected_day6.MoviesTheaterOne == null)
                {
                    new_selected_day6.MoviesTheaterOne = new List<Showing>();
                    Movie movie_to_add = new Movie();
                    movie_to_add.Actors = mov4.Actors;
                    movie_to_add.Genres = mov4.Genres;
                    movie_to_add.MovieID = mov4.MovieID;
                    movie_to_add.MovieNumber = mov4.MovieNumber;
                    movie_to_add.MPAA = mov4.MPAA;
                    movie_to_add.ReleaseDate = mov4.ReleaseDate;
                    movie_to_add.RunTime = mov4.RunTime;
                    movie_to_add.Showings = mov4.Showings;
                    movie_to_add.Tagline = mov4.Tagline;
                    movie_to_add.Title = mov4.Title;



                    Showing showing_to_add = new Showing();
                    showing_to_add.ShowingID = showing_last_selection.ShowingID;
                    showing_to_add.SpecialEvent = showing_last_selection.SpecialEvent;
                    showing_to_add.StartTime = showing_last_selection.StartTime;
                    showing_to_add.EndTime = showing_last_selection.EndTime;
                    showing_to_add.SelectedMovie = movie_to_add;
                    showing_to_add.Tickets = showing_last_selection.Tickets;




                    new_selected_day6.MoviesTheaterOne.Add(showing_last_selection);
                    db.Entry(new_selected_day3).State = System.Data.Entity.EntityState.Modified;

                    db.Entry(new_selected_day3).CurrentValues.SetValues(new_selected_day6);
                    await db.SaveChangesAsync();

                }
                else
                {
                    Movie movie_to_add = new Movie();
                    movie_to_add.Actors = mov4.Actors;
                    movie_to_add.Genres = mov4.Genres;
                    movie_to_add.MovieID = mov4.MovieID;
                    movie_to_add.MovieNumber = mov4.MovieNumber;
                    movie_to_add.MPAA = mov4.MPAA;
                    movie_to_add.ReleaseDate = mov4.ReleaseDate;
                    movie_to_add.RunTime = mov4.RunTime;
                    movie_to_add.Showings = mov4.Showings;
                    movie_to_add.Tagline = mov4.Tagline;
                    movie_to_add.Title = mov4.Title;







                    Showing showing_to_add = new Showing();
                    showing_to_add.ShowingID = showing_last_selection.ShowingID;
                    showing_to_add.SpecialEvent = showing_last_selection.SpecialEvent;
                    showing_to_add.StartTime = showing_last_selection.StartTime;
                    showing_to_add.EndTime = showing_last_selection.EndTime;
                    showing_to_add.SelectedMovie = movie_to_add;
                    showing_to_add.Tickets = showing_last_selection.Tickets;




                    new_selected_day6.MoviesTheaterOne.Add(showing_last_selection);
                    db.Entry(new_selected_day3).State = System.Data.Entity.EntityState.Modified;

                    db.Entry(new_selected_day3).CurrentValues.SetValues(new_selected_day6);
                    await db.SaveChangesAsync();

                }

            }
            else
            {
                if (new_selected_day6.MoviesTheaterTwo == null)
                {
                    new_selected_day6.MoviesTheaterTwo = new List<Showing>();
                    Movie movie_to_add = new Movie();
                    movie_to_add.Actors = mov4.Actors;
                    movie_to_add.Genres = mov4.Genres;
                    movie_to_add.MovieID = mov4.MovieID;
                    movie_to_add.MovieNumber = mov4.MovieNumber;
                    movie_to_add.MPAA = mov4.MPAA;
                    movie_to_add.ReleaseDate = mov4.ReleaseDate;
                    movie_to_add.RunTime = mov4.RunTime;
                    movie_to_add.Showings = mov4.Showings;
                    movie_to_add.Tagline = mov4.Tagline;
                    movie_to_add.Title = mov4.Title;



                    Showing showing_to_add = new Showing();
                    showing_to_add.ShowingID = showing_last_selection.ShowingID;
                    showing_to_add.SpecialEvent = showing_last_selection.SpecialEvent;
                    showing_to_add.StartTime = showing_last_selection.StartTime;
                    showing_to_add.EndTime = showing_last_selection.EndTime;
                    showing_to_add.SelectedMovie = movie_to_add;
                    showing_to_add.Tickets = showing_last_selection.Tickets;




                    new_selected_day6.MoviesTheaterTwo.Add(showing_last_selection);
                    db.Entry(new_selected_day3).State = System.Data.Entity.EntityState.Modified;

                    db.Entry(new_selected_day3).CurrentValues.SetValues(new_selected_day6);
                    await db.SaveChangesAsync();


                }
                else
                {
                    Movie movie_to_add = new Movie();
                    movie_to_add.Actors = mov4.Actors;
                    movie_to_add.Genres = mov4.Genres;
                    movie_to_add.MovieID = mov4.MovieID;
                    movie_to_add.MovieNumber = mov4.MovieNumber;
                    movie_to_add.MPAA = mov4.MPAA;
                    movie_to_add.ReleaseDate = mov4.ReleaseDate;
                    movie_to_add.RunTime = mov4.RunTime;
                    movie_to_add.Showings = mov4.Showings;
                    movie_to_add.Tagline = mov4.Tagline;
                    movie_to_add.Title = mov4.Title;



                    Showing showing_to_add = new Showing();
                    showing_to_add.ShowingID = showing_last_selection.ShowingID;
                    showing_to_add.SpecialEvent = showing_last_selection.SpecialEvent;
                    showing_to_add.StartTime = showing_last_selection.StartTime;
                    showing_to_add.EndTime = showing_last_selection.EndTime;
                    showing_to_add.SelectedMovie = movie_to_add;
                    showing_to_add.Tickets = showing_last_selection.Tickets;

                    new_selected_day6.MoviesTheaterTwo.Add(showing_last_selection);
                    db.Entry(new_selected_day3).CurrentValues.SetValues(new_selected_day6);
                    db.Entry(new_selected_day3).State = System.Data.Entity.EntityState.Modified;
                    await db.SaveChangesAsync();

                }

            }

            Day new_selected_day7 = db.Days.Where(o => o.DayStartTime.Day == created_date.Day && o.DayStartTime.Month == created_date.Month).FirstOrDefault();
            Day new_selected_day9= db.Days.Find(new_selected_day7.DateID);


            try
            {
                db.Entry(new_selected_day9).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = new_selected_day9.DateID });
            }
            catch
            {
                return View();
            }
        }



        // GET: MovieScheduler/Details/5
        public ActionResult Details(int? id)
        {
            AppDbContext db = new AppDbContext();

            db.Configuration.ProxyCreationEnabled = false;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Day selected_day = db.Days.Find(id);
            List<Showing> selected_showingsone = db.Showings.Where(o => o.StartTime.Day == selected_day.DayStartTime.Day && o.TheaterID == 1).ToList();
            List<Showing> selected_showingstwo = db.Showings.Where(o => o.StartTime.Day == selected_day.DayStartTime.Day && o.TheaterID == 2).ToList();



            if (selected_day == null)
            {
                return HttpNotFound();
            }

            if (selected_showingsone == null)
            {
                ViewBag.TheaterOneMovies = new List<Showing>();

            }
            else
            {
                ViewBag.TheaterOneMovies = selected_showingsone;
            }
            if (selected_showingstwo == null)
            {
                ViewBag.TheaterTwoMovies = new List<Showing>();
            }
            else
            {
                ViewBag.TheaterTwoMovies = selected_showingstwo;
            }



            return View(selected_day);
        }

        // GET: MovieScheduler/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: MovieScheduler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RescheduleShowing(int? id)
        {
            db.Configuration.ProxyCreationEnabled = false;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Showing selected_showing = db.Showings.Find(id);

            if (selected_showing == null)
            {
                return HttpNotFound();
            }
            String showing_movie_title = selected_showing.SelectedMovie.Title;
            db.Showings.Remove(selected_showing);
            db.SaveChanges();

            return RedirectToAction("RescheduleShowing", showing_movie_title);
        }

        // POST: MovieScheduler/Create
        public ActionResult RescheduleShowing(String movie_title)
        {
            db.Configuration.ProxyCreationEnabled = false;

            ViewBag.MovieTitle = movie_title;

            return View();
        }

        // POST: MovieScheduler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CancelShowing(int? id)
        {
            db.Configuration.ProxyCreationEnabled = false;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Day selected_day = db.Days.Find(id);

            if (selected_day == null)
            {
                return HttpNotFound();
            }
            return View(selected_day);
        }




        // POST: MovieScheduler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieScheduler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieScheduler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieScheduler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieScheduler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
