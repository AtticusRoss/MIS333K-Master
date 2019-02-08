using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LonghornCinemaReboot.DAL;

namespace LonghornCinemaReboot.Utilities
{
    public class GenerateNextMovieNumber
    {
        public static Int32 GetNextMovieNumber()
        {
            //we need a db context to connect to the database
            AppDbContext db = new AppDbContext();

            Int32 intMaxMovieNumber; //the current maximum movie number
            Int32 intNextMovieNumber; //the movie number for the next class

            if (db.Orders.Count() == 0) //there are no registrations in the database yet
            {
                intMaxMovieNumber = 3000; //movie numbers start at 3001
            }
            else
            {
                intMaxMovieNumber = db.Orders.Max(c => c.OrderNumber); //this is the highest number in the database right now
            }

            //add one to the current max to find the next one
            intNextMovieNumber = intMaxMovieNumber + 1;

            //return the value
            return intNextMovieNumber;
        }
    }
}