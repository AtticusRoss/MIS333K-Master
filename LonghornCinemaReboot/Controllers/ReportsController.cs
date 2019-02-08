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
    public class ReportsController : Controller
    {
        //Create an instance of the db context
        AppDbContext db = new AppDbContext();

        // GET: Reports
        public ActionResult Index(String SearchString)
        {
            //Store total repo count in ViewBag
            ViewBag.MovieCount = db.Showings.ToList().Count();

            //Create list of repos containing list of customers to display on form
            List<Showing> SelectedShowings = new List<Showing>();

            //Use LINQ to filter wanted repos
            var query = from m in db.Showings
                        select m;

            //Check to see if SearchString is null. If null, display all; else, limit query to repos containing string in repo name or user name
            if (SearchString == null || SearchString == "")
            {
                //Do nothing, keep query as is
            }
            else
            {
                query = query.Where(m => m.SelectedMovie.Title.Contains(SearchString));
            }

            //Use .ToList() method to execute query
            SelectedShowings = query.ToList();

            //Add total repo count and selected repo count
            ViewBag.TotalMovies = db.Showings.Count();
            ViewBag.SelectedShowings = SelectedShowings.Count();

            //Send SelectedRepositories to the view
            return View(SelectedShowings.OrderBy(m => m.ShowingID));
        }

        // GET: Reports/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reports/Create
        [HttpPost]
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

        // GET: Reports/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reports/Edit/5
        [HttpPost]
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

        // GET: Reports/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reports/Delete/5
        [HttpPost]
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





        public ActionResult ShowingSearch()
        {

            ViewBag.Allmovies = GetAllMovies();
            ViewBag.AllMPAA = GetAllMPAAs();
            return View();
        }

        public ActionResult DisplaySearchResults(DateTime? datStartTime, DateTime? datEndTime, string strStartDate, string strEndDate, int[] SelectedShowings, int[] SelectedMPAA)
        {
            //Create list of movies to display on form
            //List<Movie> ReportMovies = new List<Movie>();
            List<Showing> ReportShowings = new List<Showing>();

            //Use LINQ to filter wanted movies
            var query = from m in db.Showings
                        select m;

            //Check if strSearchTitle is null; else limit query to movies containing string in title
            if (datStartTime != null && datEndTime != null)
            {
                query = query.Where(m => datStartTime > m.StartTime);
                query = query.Where(m => datEndTime < m.EndTime);
            }
            
            /*
            if (strStartDate != null && strEndDate != null)
            {
                query = query.Where(m => strStartDate > m.Days.DateID);
                query = query.Where(m => strEndDate <= m.Days.DateID1);
            }
            */

            //Check if genre was selected
            if (SelectedShowings != null)
            {
                bool first = true;

                //Create second query to filter from
                var q2 = query;

                //Iterate through list
                foreach (int i in SelectedShowings)
                {
                    //If first, trim original query, then switch flag
                    if (first)
                    {
                        query = query.Where(m => m.SelectedMovie.Equals(i));
                        first = false;
                    }

                    //Find union of original trimmed query and second trimmed query
                    else
                    {
                        query = query.Where(m => m.SelectedMovie.Equals(i));
                    }
                }
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
                        query = query.Where(m => m.SelectedMovie.MPAA.MPAAID == i);
                        first = false;
                    }

                    //Find union of original trimmed query and second trimmed query
                    else
                    {
                        query = query.Where(m => m.SelectedMovie.MPAA.MPAAID == i);
                    }
                }
            }



            //Use .ToList() method to execute query
            ReportShowings = query.ToList();

            //Add total movie count and selected movie count
            ViewBag.TotalMovies = db.Showings.Count();
            //ViewBag.SelectedShowings = SelectedShowings.Count();

            //Send SelectedRepositories to the view
            return View("~/Views/Reports/Index.cshtml", ReportShowings.OrderBy(m => m.SelectedMovie));

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

        //method to get all Movies for the ViewBag
        public SelectList GetAllMovies()
        {
            //Get the list of courses in order by course name
            List<Movie> allMovies = db.Movies.OrderBy(c => c.MovieNumber).ToList();

            //convert the list to a select list
            SelectList selMovie = new SelectList(allMovies, "MovieID", "Title");

            //return the select list
            return selMovie;
        }
    }
}
