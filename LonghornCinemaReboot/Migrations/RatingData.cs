using LonghornCinemaReboot.DAL;
using LonghornCinemaReboot.Models;
using LonghornCinemaReboot.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace LonghornCinemaReboot.Migrations
{
    public class RatingData
    {
        public void SeedRatings(AppDbContext db)
        {

            MPAA rating1 = new MPAA();
            rating1.MPAAName = "Unrated";
            db.MPAA.AddOrUpdate(r => r.MPAAName, rating1);
            db.SaveChanges();

            MPAA rating2 = new MPAA();
            rating2.MPAAName = "G";
            db.MPAA.AddOrUpdate(r => r.MPAAName, rating2);
            db.SaveChanges();

            MPAA rating3 = new MPAA();
            rating3.MPAAName = "PG";
            db.MPAA.AddOrUpdate(r => r.MPAAName, rating3);
            db.SaveChanges();

            MPAA rating4 = new MPAA();
            rating4.MPAAName = "PG-13";
            db.MPAA.AddOrUpdate(r => r.MPAAName, rating4);
            db.SaveChanges();

            MPAA rating5 = new MPAA();
            rating5.MPAAName = "NC-17";
            db.MPAA.AddOrUpdate(r => r.MPAAName, rating5);
            db.SaveChanges();

            MPAA rating6 = new MPAA();
            rating6.MPAAName = "R";
            db.MPAA.AddOrUpdate(r => r.MPAAName, rating6);
            db.SaveChanges();
        }
    }
}