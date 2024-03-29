﻿using LonghornCinemaReboot.DAL;
using LonghornCinemaReboot.Models;
using LonghornCinemaReboot.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace LonghornCinemaReboot.Migrations
{
    public class GenreData
    {
        public void SeedGenre(AppDbContext db)
        {
            Genre genre1 = new Genre();
            genre1.GenreName = "Musical";
            db.Genres.AddOrUpdate(g => g.GenreName, genre1);
            db.SaveChanges();

            Genre genre2 = new Genre();
            genre2.GenreName = "Comedy";
            db.Genres.AddOrUpdate(g => g.GenreName, genre2);
            db.SaveChanges();

            Genre genre3 = new Genre();
            genre3.GenreName = "Romance";
            db.Genres.AddOrUpdate(g => g.GenreName, genre3);
            db.SaveChanges();

            Genre genre4 = new Genre();
            genre4.GenreName = "Fantasy";
            db.Genres.AddOrUpdate(g => g.GenreName, genre4);
            db.SaveChanges();

            Genre genre5 = new Genre();
            genre5.GenreName = "Animation";
            db.Genres.AddOrUpdate(g => g.GenreName, genre5);
            db.SaveChanges();

            Genre genre6 = new Genre();
            genre6.GenreName = "Family";
            db.Genres.AddOrUpdate(g => g.GenreName, genre6);
            db.SaveChanges();

            Genre genre7 = new Genre();
            genre7.GenreName = "Adventure";
            db.Genres.AddOrUpdate(g => g.GenreName, genre7);
            db.SaveChanges();

            Genre genre8 = new Genre();
            genre8.GenreName = "Drama";
            db.Genres.AddOrUpdate(g => g.GenreName, genre8);
            db.SaveChanges();

            Genre genre9 = new Genre();
            genre9.GenreName = "War";
            db.Genres.AddOrUpdate(g => g.GenreName, genre9);
            db.SaveChanges();

            Genre genre10 = new Genre();
            genre10.GenreName = "Western";
            db.Genres.AddOrUpdate(g => g.GenreName, genre10);
            db.SaveChanges();

            Genre genre11 = new Genre();
            genre11.GenreName = "Horror";
            db.Genres.AddOrUpdate(g => g.GenreName, genre11);
            db.SaveChanges();

            Genre genre12 = new Genre();
            genre12.GenreName = "Thriller";
            db.Genres.AddOrUpdate(g => g.GenreName, genre12);
            db.SaveChanges();

            Genre genre13 = new Genre();
            genre13.GenreName = "Crime";
            db.Genres.AddOrUpdate(g => g.GenreName, genre13);
            db.SaveChanges();

            Genre genre14 = new Genre();
            genre14.GenreName = "Action";
            db.Genres.AddOrUpdate(g => g.GenreName, genre14);
            db.SaveChanges();

            Genre genre15 = new Genre();
            genre15.GenreName = "History";
            db.Genres.AddOrUpdate(g => g.GenreName, genre15);
            db.SaveChanges();

            Genre genre16 = new Genre();
            genre16.GenreName = "Science Fiction";
            db.Genres.AddOrUpdate(g => g.GenreName, genre16);
            db.SaveChanges();

            Genre genre17 = new Genre();
            genre17.GenreName = "Mystery";
            db.Genres.AddOrUpdate(g => g.GenreName, genre17);
            db.SaveChanges();
        }
    }
}