﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;

//TODO: Change these using statements to match your project
using LonghornCinemaReboot.DAL;
using LonghornCinemaReboot.Models;
using System;

//TODO: Change this namespace to match your project
namespace LonghornCinemaReboot.Migrations
{
    //add identity data
    public class SeedCustomers
    {
        public void AddCustomers(AppDbContext db)
        {
            //create a user manager and a role manager to use for this method
            AppUserManager UserManager = new AppUserManager(new UserStore<AppUser>(db));


            AppUser customer1 = db.Users.FirstOrDefault(u => u.Email == "cbaker@example.com");
            customer1 = new AppUser();
            customer1.CustomerNumber = 5001;
            customer1.LastName = "Baker";
            customer1.MiddleInitial = "L.";
            customer1.FirstName = "Christopher";
            customer1.Birthday = new DateTime(1949, 11, 23);
            customer1.Address = "1245 Lake Anchorage Blvd.";
            customer1.City = "Austin";
            customer1.State = "TX";
            customer1.ZipCode = 78705;
            customer1.SSN = 9075571146;
            customer1.PhoneNumber = "5125550180";
            customer1.UserName = "cbaker@example.com";
            customer1.Email = "cbaker@example.com";
            customer1.PopcornPoints = 110;
            var resultcustomer1 = UserManager.Create(customer1, "hello1");
            db.SaveChanges();
            customer1 = db.Users.FirstOrDefault(u => u.Email == "cbaker@example.com");
            if (UserManager.IsInRole(customer1.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer1.Id, "Customer");
            }

            AppUser customer2 = db.Users.FirstOrDefault(u => u.Email == "banker@longhorn.net");
            customer2 = new AppUser();
            customer2.CustomerNumber = 5002;
            customer2.LastName = "Banks";
            customer2.MiddleInitial = "";
            customer2.FirstName = "Michelle";
            customer2.Birthday = new DateTime(1962, 11, 27);
            customer2.Address = "1300 Tall Pine Lane";
            customer2.City = "Austin";
            customer2.State = "TX";
            customer2.ZipCode = 78712;
            customer2.SSN = 9042678873;
            customer2.PhoneNumber = "5125550183";
            customer2.UserName = "banker@longhorn.net";
            customer2.Email = "banker@longhorn.net";
            customer2.PopcornPoints = 40;
            var resultcustomer2 = UserManager.Create(customer2, "potato");
            db.SaveChanges();
            customer2 = db.Users.FirstOrDefault(u => u.Email == "banker@longhorn.net");
            if (UserManager.IsInRole(customer2.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer2.Id, "Customer");
            }

            AppUser customer3 = db.Users.FirstOrDefault(u => u.Email == "franco@example.com");
            customer3 = new AppUser();
            customer3.CustomerNumber = 5003;
            customer3.LastName = "Broccolo";
            customer3.MiddleInitial = "V";
            customer3.FirstName = "Franco";
            customer3.Birthday = new DateTime(1992, 10, 11);
            customer3.Address = "62 Browning Road";
            customer3.City = "Austin";
            customer3.State = "TX";
            customer3.ZipCode = 78704;
            customer3.SSN = 4155659699;
            customer3.PhoneNumber = "5125550128";
            customer3.UserName = "franco@example.com";
            customer3.Email = "franco@example.com";
            customer3.PopcornPoints = 30;
            var resultcustomer3 = UserManager.Create(customer3, "painting");
            db.SaveChanges();
            customer3 = db.Users.FirstOrDefault(u => u.Email == "franco@example.com");
            if (UserManager.IsInRole(customer3.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer3.Id, "Customer");
            }

            AppUser customer4 = db.Users.FirstOrDefault(u => u.Email == "wchang@example.com");
            customer4 = new AppUser();
            customer4.CustomerNumber = 5004;
            customer4.LastName = "Chang";
            customer4.MiddleInitial = "L";
            customer4.FirstName = "Wendy";
            customer4.Birthday = new DateTime(1997, 5, 16);
            customer4.Address = "202 Bellmont Hall";
            customer4.City = "Round Rock";
            customer4.State = "TX";
            customer4.ZipCode = 78681;
            customer4.SSN = 9075943222;
            customer4.PhoneNumber = "5125550133";
            customer4.UserName = "wchang@example.com";
            customer4.Email = "wchang@example.com";
            customer4.PopcornPoints = 0;
            var resultcustomer4 = UserManager.Create(customer4, "texas1");
            db.SaveChanges();
            customer4 = db.Users.FirstOrDefault(u => u.Email == "wchang@example.com");
            if (UserManager.IsInRole(customer4.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer4.Id, "Customer");
            }

            AppUser customer5 = db.Users.FirstOrDefault(u => u.Email == "limchou@gogle.com");
            customer5 = new AppUser();
            customer5.CustomerNumber = 5005;
            customer5.LastName = "Chou";
            customer5.MiddleInitial = "";
            customer5.FirstName = "Lim";
            customer5.Birthday = new DateTime(1970, 4, 6);
            customer5.Address = "1600 Teresa Lane";
            customer5.City = "Austin";
            customer5.State = "TX";
            customer5.ZipCode = 78705;
            customer5.SSN = 8137724599;
            customer5.PhoneNumber = "5125550102";
            customer5.UserName = "limchou@gogle.com";
            customer5.Email = "limchou@gogle.com";
            customer5.PopcornPoints = 40;
            var resultcustomer5 = UserManager.Create(customer5, "Anchorage");
            db.SaveChanges();
            customer5 = db.Users.FirstOrDefault(u => u.Email == "limchou@gogle.com");
            if (UserManager.IsInRole(customer5.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer5.Id, "Customer");
            }

            AppUser customer6 = db.Users.FirstOrDefault(u => u.Email == "shdixon@aoll.com");
            customer6 = new AppUser();
            customer6.CustomerNumber = 5006;
            customer6.LastName = "Dixon";
            customer6.MiddleInitial = "D";
            customer6.FirstName = "Shan";
            customer6.Birthday = new DateTime(1984, 1, 12);
            customer6.Address = "234 Holston Circle";
            customer6.City = "Austin";
            customer6.State = "TX";
            customer6.ZipCode = 78712;
            customer6.SSN = 2052643255;
            customer6.PhoneNumber = "5125550146";
            customer6.UserName = "shdixon@aoll.com";
            customer6.Email = "shdixon@aoll.com";
            customer6.PopcornPoints = 20;
            var resultcustomer6 = UserManager.Create(customer6, "pepperoni");
            db.SaveChanges();
            customer6 = db.Users.FirstOrDefault(u => u.Email == "shdixon@aoll.com");
            if (UserManager.IsInRole(customer6.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer6.Id, "Customer");
            }

            AppUser customer7 = db.Users.FirstOrDefault(u => u.Email == "j.b.evans@aheca.org");
            customer7 = new AppUser();
            customer7.CustomerNumber = 5007;
            customer7.LastName = "Evans";
            customer7.MiddleInitial = "";
            customer7.FirstName = "Jim Bob";
            customer7.Birthday = new DateTime(1959, 9, 9);
            customer7.Address = "506 Farrell Circle";
            customer7.City = "Georgetown";
            customer7.State = "TX";
            customer7.ZipCode = 78628;
            customer7.SSN = 2102565834;
            customer7.PhoneNumber = "5125550170";
            customer7.UserName = "j.b.evans@aheca.org";
            customer7.Email = "j.b.evans@aheca.org";
            customer7.PopcornPoints = 50;
            var resultcustomer7 = UserManager.Create(customer7, "longhorns");
            db.SaveChanges();
            customer7 = db.Users.FirstOrDefault(u => u.Email == "j.b.evans@aheca.org");
            if (UserManager.IsInRole(customer7.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer7.Id, "Customer");
            }

            AppUser customer8 = db.Users.FirstOrDefault(u => u.Email == "feeley@penguin.org");
            customer8 = new AppUser();
            customer8.CustomerNumber = 5008;
            customer8.LastName = "Feeley";
            customer8.MiddleInitial = "K";
            customer8.FirstName = "Lou Ann";
            customer8.Birthday = new DateTime(2001, 1, 12);
            customer8.Address = "600 S 8th Street W";
            customer8.City = "Austin";
            customer8.State = "TX";
            customer8.ZipCode = 78746;
            customer8.SSN = 4062556749;
            customer8.PhoneNumber = "5125550105";
            customer8.UserName = "feeley@penguin.org";
            customer8.Email = "feeley@penguin.org";
            customer8.PopcornPoints = 170;
            var resultcustomer8 = UserManager.Create(customer8, "aggies");
            db.SaveChanges();
            customer8 = db.Users.FirstOrDefault(u => u.Email == "feeley@penguin.org");
            if (UserManager.IsInRole(customer8.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer8.Id, "Customer");
            }

            AppUser customer9 = db.Users.FirstOrDefault(u => u.Email == "tfreeley@minnetonka.ci.us");
            customer9 = new AppUser();
            customer9.CustomerNumber = 5009;
            customer9.LastName = "Freeley";
            customer9.MiddleInitial = "P";
            customer9.FirstName = "Tesa";
            customer9.Birthday = new DateTime(1991, 2, 4);
            customer9.Address = "4448 Fairview Ave.";
            customer9.City = "Horseshoe Bay";
            customer9.State = "TX";
            customer9.ZipCode = 78657;
            customer9.SSN = 6123255687;
            customer9.PhoneNumber = "5125550114";
            customer9.UserName = "tfreeley@minnetonka.ci.us";
            customer9.Email = "tfreeley@minnetonka.ci.us";
            customer9.PopcornPoints = 160;
            var resultcustomer9 = UserManager.Create(customer9, "raiders");
            db.SaveChanges();
            customer9 = db.Users.FirstOrDefault(u => u.Email == "tfreeley@minnetonka.ci.us");
            if (UserManager.IsInRole(customer9.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer9.Id, "Customer");
            }

            AppUser customer10 = db.Users.FirstOrDefault(u => u.Email == "mgarcia@gogle.com");
            customer10 = new AppUser();
            customer10.CustomerNumber = 5010;
            customer10.LastName = "Garcia";
            customer10.MiddleInitial = "L";
            customer10.FirstName = "Margaret";
            customer10.Birthday = new DateTime(1991, 10, 2);
            customer10.Address = "594 Longview";
            customer10.City = "Austin";
            customer10.State = "TX";
            customer10.ZipCode = 78727;
            customer10.SSN = 4066593544;
            customer10.PhoneNumber = "5125550155";
            customer10.UserName = "mgarcia@gogle.com";
            customer10.Email = "mgarcia@gogle.com";
            customer10.PopcornPoints = 10;
            var resultcustomer10 = UserManager.Create(customer10, "mustangs");
            db.SaveChanges();
            customer10 = db.Users.FirstOrDefault(u => u.Email == "mgarcia@gogle.com");
            if (UserManager.IsInRole(customer10.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer10.Id, "Customer");
            }

            AppUser customer11 = db.Users.FirstOrDefault(u => u.Email == "chaley@thug.com");
            customer11 = new AppUser();
            customer11.CustomerNumber = 5011;
            customer11.LastName = "Haley";
            customer11.MiddleInitial = "E";
            customer11.FirstName = "Charles";
            customer11.Birthday = new DateTime(1974, 7, 10);
            customer11.Address = "One Cowboy Pkwy";
            customer11.City = "Austin";
            customer11.State = "TX";
            customer11.ZipCode = 78712;
            customer11.SSN = 2148475583;
            customer11.PhoneNumber = "5125550116";
            customer11.UserName = "chaley@thug.com";
            customer11.Email = "chaley@thug.com";
            customer11.PopcornPoints = 40;
            var resultcustomer11 = UserManager.Create(customer11, "onetime");
            db.SaveChanges();
            customer11 = db.Users.FirstOrDefault(u => u.Email == "chaley@thug.com");
            if (UserManager.IsInRole(customer11.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer11.Id, "Customer");
            }

            AppUser customer12 = db.Users.FirstOrDefault(u => u.Email == "jeffh@sonic.com");
            customer12 = new AppUser();
            customer12.CustomerNumber = 5012;
            customer12.LastName = "Hampton";
            customer12.MiddleInitial = "T.";
            customer12.FirstName = "Jeffrey";
            customer12.Birthday = new DateTime(2004, 3, 10);
            customer12.Address = "337 38th St.";
            customer12.City = "San Marcos";
            customer12.State = "TX";
            customer12.ZipCode = 78666;
            customer12.SSN = 9076978613;
            customer12.PhoneNumber = "5125550150";
            customer12.UserName = "jeffh@sonic.com";
            customer12.Email = "jeffh@sonic.com";
            customer12.PopcornPoints = 150;
            var resultcustomer12 = UserManager.Create(customer12, "hampton1");
            db.SaveChanges();
            customer12 = db.Users.FirstOrDefault(u => u.Email == "jeffh@sonic.com");
            if (UserManager.IsInRole(customer12.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer12.Id, "Customer");
            }

            AppUser customer13 = db.Users.FirstOrDefault(u => u.Email == "wjhearniii@umich.org");
            customer13 = new AppUser();
            customer13.CustomerNumber = 5013;
            customer13.LastName = "Hearn";
            customer13.MiddleInitial = "B";
            customer13.FirstName = "John";
            customer13.Birthday = new DateTime(1950, 8, 5);
            customer13.Address = "4225 North First";
            customer13.City = "Austin";
            customer13.State = "TX";
            customer13.ZipCode = 78705;
            customer13.SSN = 5208965621;
            customer13.PhoneNumber = "5125550196";
            customer13.UserName = "wjhearniii@umich.org";
            customer13.Email = "wjhearniii@umich.org";
            customer13.PopcornPoints = 0;
            var resultcustomer13 = UserManager.Create(customer13, "jhearn22");
            db.SaveChanges();
            customer13 = db.Users.FirstOrDefault(u => u.Email == "wjhearniii@umich.org");
            if (UserManager.IsInRole(customer13.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer13.Id, "Customer");
            }

            AppUser customer14 = db.Users.FirstOrDefault(u => u.Email == "ahick@yaho.com");
            customer14 = new AppUser();
            customer14.CustomerNumber = 5014;
            customer14.LastName = "Hicks";
            customer14.MiddleInitial = "J";
            customer14.FirstName = "Anthony";
            customer14.Birthday = new DateTime(2004, 12, 8);
            customer14.Address = "32 NE Garden Ln., Ste 910";
            customer14.City = "Austin";
            customer14.State = "TX";
            customer14.ZipCode = 78712;
            customer14.SSN = 7355788965;
            customer14.PhoneNumber = "5125550188";
            customer14.UserName = "ahick@yaho.com";
            customer14.Email = "ahick@yaho.com";
            customer14.PopcornPoints = 60;
            var resultcustomer14 = UserManager.Create(customer14, "hickhickup");
            db.SaveChanges();
            customer14 = db.Users.FirstOrDefault(u => u.Email == "ahick@yaho.com");
            if (UserManager.IsInRole(customer14.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer14.Id, "Customer");
            }

            AppUser customer15 = db.Users.FirstOrDefault(u => u.Email == "ingram@jack.com");
            customer15 = new AppUser();
            customer15.CustomerNumber = 5015;
            customer15.LastName = "Ingram";
            customer15.MiddleInitial = "S.";
            customer15.FirstName = "Brad";
            customer15.Birthday = new DateTime(2001, 9, 5);
            customer15.Address = "6548 La Posada Ct.";
            customer15.City = "New York";
            customer15.State = "NY";
            customer15.ZipCode = 10101;
            customer15.SSN = 9074678821;
            customer15.PhoneNumber = "5125550116";
            customer15.UserName = "ingram@jack.com";
            customer15.Email = "ingram@jack.com";
            customer15.PopcornPoints = 20;
            var resultcustomer15 = UserManager.Create(customer15, "ingram2015");
            db.SaveChanges();
            customer15 = db.Users.FirstOrDefault(u => u.Email == "ingram@jack.com");
            if (UserManager.IsInRole(customer15.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer15.Id, "Customer");
            }

            AppUser customer16 = db.Users.FirstOrDefault(u => u.Email == "toddj@yourmom.com");
            customer16 = new AppUser();
            customer16.CustomerNumber = 5016;
            customer16.LastName = "Jacobs";
            customer16.MiddleInitial = "L.";
            customer16.FirstName = "Todd";
            customer16.Birthday = new DateTime(1999, 1, 20);
            customer16.Address = "4564 Elm St.";
            customer16.City = "Austin";
            customer16.State = "TX";
            customer16.ZipCode = 78729;
            customer16.SSN = 9074653365;
            customer16.PhoneNumber = "5125550166";
            customer16.UserName = "toddj@yourmom.com";
            customer16.Email = "toddj@yourmom.com";
            customer16.PopcornPoints = 170;
            var resultcustomer16 = UserManager.Create(customer16, "toddy25");
            db.SaveChanges();
            customer16 = db.Users.FirstOrDefault(u => u.Email == "toddj@yourmom.com");
            if (UserManager.IsInRole(customer16.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer16.Id, "Customer");
            }

            AppUser customer17 = db.Users.FirstOrDefault(u => u.Email == "thequeen@aska.net");
            customer17 = new AppUser();
            customer17.CustomerNumber = 5017;
            customer17.LastName = "Lawrence";
            customer17.MiddleInitial = "M.";
            customer17.FirstName = "Victoria";
            customer17.Birthday = new DateTime(2000, 4, 14);
            customer17.Address = "6639 Butterfly Ln.";
            customer17.City = "Beverly Hills";
            customer17.State = "CA";
            customer17.ZipCode = 90210;
            customer17.SSN = 9079457399;
            customer17.PhoneNumber = "5125550173";
            customer17.UserName = "thequeen@aska.net";
            customer17.Email = "thequeen@aska.net";
            customer17.PopcornPoints = 130;
            var resultcustomer17 = UserManager.Create(customer17, "something");
            db.SaveChanges();
            customer17 = db.Users.FirstOrDefault(u => u.Email == "thequeen@aska.net");
            if (UserManager.IsInRole(customer17.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer17.Id, "Customer");
            }

            AppUser customer18 = db.Users.FirstOrDefault(u => u.Email == "linebacker@gogle.com");
            customer18 = new AppUser();
            customer18.CustomerNumber = 5018;
            customer18.LastName = "Lineback";
            customer18.MiddleInitial = "W";
            customer18.FirstName = "Erik";
            customer18.Birthday = new DateTime(2003, 12, 2);
            customer18.Address = "1300 Netherland St";
            customer18.City = "Austin";
            customer18.State = "TX";
            customer18.ZipCode = 78758;
            customer18.SSN = 3032449976;
            customer18.PhoneNumber = "5125550167";
            customer18.UserName = "linebacker@gogle.com";
            customer18.Email = "linebacker@gogle.com";
            customer18.PopcornPoints = 60;
            var resultcustomer18 = UserManager.Create(customer18, "Password1");
            db.SaveChanges();
            customer18 = db.Users.FirstOrDefault(u => u.Email == "linebacker@gogle.com");
            if (UserManager.IsInRole(customer18.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer18.Id, "Customer");
            }

            AppUser customer19 = db.Users.FirstOrDefault(u => u.Email == "elowe@netscare.net");
            customer19 = new AppUser();
            customer19.CustomerNumber = 5019;
            customer19.LastName = "Lowe";
            customer19.MiddleInitial = "S";
            customer19.FirstName = "Ernest";
            customer19.Birthday = new DateTime(1977, 12, 7);
            customer19.Address = "3201 Pine Drive";
            customer19.City = "New Braunfels";
            customer19.State = "TX";
            customer19.ZipCode = 78130;
            customer19.SSN = 7135344627;
            customer19.PhoneNumber = "5125550187";
            customer19.UserName = "elowe@netscare.net";
            customer19.Email = "elowe@netscare.net";
            customer19.PopcornPoints = 20;
            var resultcustomer19 = UserManager.Create(customer19, "aclfest2017");
            db.SaveChanges();
            customer19 = db.Users.FirstOrDefault(u => u.Email == "elowe@netscare.net");
            if (UserManager.IsInRole(customer19.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer19.Id, "Customer");
            }

            AppUser customer20 = db.Users.FirstOrDefault(u => u.Email == "cluce@gogle.com");
            customer20 = new AppUser();
            customer20.CustomerNumber = 5020;
            customer20.LastName = "Luce";
            customer20.MiddleInitial = "B";
            customer20.FirstName = "Chuck";
            customer20.Birthday = new DateTime(1949, 3, 16);
            customer20.Address = "2345 Rolling Clouds";
            customer20.City = "Cactus";
            customer20.State = "TX";
            customer20.ZipCode = 79013;
            customer20.SSN = 9546983548;
            customer20.PhoneNumber = "5125550141";
            customer20.UserName = "cluce@gogle.com";
            customer20.Email = "cluce@gogle.com";
            customer20.PopcornPoints = 180;
            var resultcustomer20 = UserManager.Create(customer20, "nothinggood");
            db.SaveChanges();
            customer20 = db.Users.FirstOrDefault(u => u.Email == "cluce@gogle.com");
            if (UserManager.IsInRole(customer20.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer20.Id, "Customer");
            }

            AppUser customer21 = db.Users.FirstOrDefault(u => u.Email == "mackcloud@george.com");
            customer21 = new AppUser();
            customer21.CustomerNumber = 5021;
            customer21.LastName = "MacLeod";
            customer21.MiddleInitial = "D.";
            customer21.FirstName = "Jennifer";
            customer21.Birthday = new DateTime(1947, 2, 21);
            customer21.Address = "2504 Far West Blvd.";
            customer21.City = "Marble Falls";
            customer21.State = "TX";
            customer21.ZipCode = 78654;
            customer21.SSN = 9074748138;
            customer21.PhoneNumber = "5125550185";
            customer21.UserName = "mackcloud@george.com";
            customer21.Email = "mackcloud@george.com";
            customer21.PopcornPoints = 170;
            var resultcustomer21 = UserManager.Create(customer21, "whatever");
            db.SaveChanges();
            customer21 = db.Users.FirstOrDefault(u => u.Email == "mackcloud@george.com");
            if (UserManager.IsInRole(customer21.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer21.Id, "Customer");
            }

            AppUser customer22 = db.Users.FirstOrDefault(u => u.Email == "cmartin@beets.com");
            customer22 = new AppUser();
            customer22.CustomerNumber = 5022;
            customer22.LastName = "Markham";
            customer22.MiddleInitial = "P.";
            customer22.FirstName = "Elizabeth";
            customer22.Birthday = new DateTime(1972, 3, 20);
            customer22.Address = "7861 Chevy Chase";
            customer22.City = "Kissimmee";
            customer22.State = "FL";
            customer22.ZipCode = 34741;
            customer22.SSN = 9074579845;
            customer22.PhoneNumber = "5125550134";
            customer22.UserName = "cmartin@beets.com";
            customer22.Email = "cmartin@beets.com";
            customer22.PopcornPoints = 100;
            var resultcustomer22 = UserManager.Create(customer22, "whocares");
            db.SaveChanges();
            customer22 = db.Users.FirstOrDefault(u => u.Email == "cmartin@beets.com");
            if (UserManager.IsInRole(customer22.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer22.Id, "Customer");
            }

            AppUser customer23 = db.Users.FirstOrDefault(u => u.Email == "clarence@yoho.com");
            customer23 = new AppUser();
            customer23.CustomerNumber = 5023;
            customer23.LastName = "Martin";
            customer23.MiddleInitial = "A";
            customer23.FirstName = "Clarence";
            customer23.Birthday = new DateTime(1992, 7, 19);
            customer23.Address = "87 Alcedo St.";
            customer23.City = "Austin";
            customer23.State = "TX";
            customer23.ZipCode = 78709;
            customer23.SSN = 9204955201;
            customer23.PhoneNumber = "5125550151";
            customer23.UserName = "clarence@yoho.com";
            customer23.Email = "clarence@yoho.com";
            customer23.PopcornPoints = 130;
            var resultcustomer23 = UserManager.Create(customer23, "xcellent");
            db.SaveChanges();
            customer23 = db.Users.FirstOrDefault(u => u.Email == "clarence@yoho.com");
            if (UserManager.IsInRole(customer23.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer23.Id, "Customer");
            }

            AppUser customer24 = db.Users.FirstOrDefault(u => u.Email == "gregmartinez@drdre.com");
            customer24 = new AppUser();
            customer24.CustomerNumber = 5024;
            customer24.LastName = "Martinez";
            customer24.MiddleInitial = "R.";
            customer24.FirstName = "Gregory";
            customer24.Birthday = new DateTime(1947, 5, 28);
            customer24.Address = "8295 Sunset Blvd.";
            customer24.City = "Red Rock";
            customer24.State = "TX";
            customer24.ZipCode = 78662;
            customer24.SSN = 9078746718;
            customer24.PhoneNumber = "5125550120";
            customer24.UserName = "gregmartinez@drdre.com";
            customer24.Email = "gregmartinez@drdre.com";
            customer24.PopcornPoints = 20;
            var resultcustomer24 = UserManager.Create(customer24, "snowsnow");
            db.SaveChanges();
            customer24 = db.Users.FirstOrDefault(u => u.Email == "gregmartinez@drdre.com");
            if (UserManager.IsInRole(customer24.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer24.Id, "Customer");
            }

            AppUser customer25 = db.Users.FirstOrDefault(u => u.Email == "cmiller@bob.com");
            customer25 = new AppUser();
            customer25.CustomerNumber = 5025;
            customer25.LastName = "Miller";
            customer25.MiddleInitial = "R.";
            customer25.FirstName = "Charles";
            customer25.Birthday = new DateTime(1990, 10, 15);
            customer25.Address = "8962 Main St.";
            customer25.City = "South Padre Island";
            customer25.State = "TX";
            customer25.ZipCode = 78597;
            customer25.SSN = 9077458615;
            customer25.PhoneNumber = "5125550198";
            customer25.UserName = "cmiller@bob.com";
            customer25.Email = "cmiller@bob.com";
            customer25.PopcornPoints = 20;
            var resultcustomer25 = UserManager.Create(customer25, "mydogspot");
            db.SaveChanges();
            customer25 = db.Users.FirstOrDefault(u => u.Email == "cmiller@bob.com");
            if (UserManager.IsInRole(customer25.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer25.Id, "Customer");
            }

            AppUser customer26 = db.Users.FirstOrDefault(u => u.Email == "knelson@aoll.com");
            customer26 = new AppUser();
            customer26.CustomerNumber = 5026;
            customer26.LastName = "Nelson";
            customer26.MiddleInitial = "T";
            customer26.FirstName = "Kelly";
            customer26.Birthday = new DateTime(1971, 7, 13);
            customer26.Address = "2601 Red River";
            customer26.City = "Disney";
            customer26.State = "OK";
            customer26.ZipCode = 74340;
            customer26.SSN = 9072926966;
            customer26.PhoneNumber = "5125550177";
            customer26.UserName = "knelson@aoll.com";
            customer26.Email = "knelson@aoll.com";
            customer26.PopcornPoints = 110;
            var resultcustomer26 = UserManager.Create(customer26, "spotmydog");
            db.SaveChanges();
            customer26 = db.Users.FirstOrDefault(u => u.Email == "knelson@aoll.com");
            if (UserManager.IsInRole(customer26.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer26.Id, "Customer");
            }

            AppUser customer27 = db.Users.FirstOrDefault(u => u.Email == "joewin@xfactor.com");
            customer27 = new AppUser();
            customer27.CustomerNumber = 5027;
            customer27.LastName = "Nguyen";
            customer27.MiddleInitial = "C";
            customer27.FirstName = "Joe";
            customer27.Birthday = new DateTime(1984, 3, 17);
            customer27.Address = "1249 4th SW St.";
            customer27.City = "Del Rio";
            customer27.State = "TX";
            customer27.ZipCode = 78841;
            customer27.SSN = 2023125897;
            customer27.PhoneNumber = "5125550174";
            customer27.UserName = "joewin@xfactor.com";
            customer27.Email = "joewin@xfactor.com";
            customer27.PopcornPoints = 150;
            var resultcustomer27 = UserManager.Create(customer27, "joejoejoe");
            db.SaveChanges();
            customer27 = db.Users.FirstOrDefault(u => u.Email == "joewin@xfactor.com");
            if (UserManager.IsInRole(customer27.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer27.Id, "Customer");
            }

            AppUser customer28 = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnews.cnn");
            customer28 = new AppUser();
            customer28.CustomerNumber = 5028;
            customer28.LastName = "O'Reilly";
            customer28.MiddleInitial = "T";
            customer28.FirstName = "Bill";
            customer28.Birthday = new DateTime(1959, 7, 8);
            customer28.Address = "8800 Gringo Drive";
            customer28.City = "Austin";
            customer28.State = "TX";
            customer28.ZipCode = 78746;
            customer28.SSN = 3173450925;
            customer28.PhoneNumber = "5125550167";
            customer28.UserName = "orielly@foxnews.cnn";
            customer28.Email = "orielly@foxnews.cnn";
            customer28.PopcornPoints = 190;
            var resultcustomer28 = UserManager.Create(customer28, "billyboy");
            db.SaveChanges();
            customer28 = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnews.cnn");
            if (UserManager.IsInRole(customer28.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer28.Id, "Customer");
            }

            AppUser customer29 = db.Users.FirstOrDefault(u => u.Email == "ankaisrad@gogle.com");
            customer29 = new AppUser();
            customer29.CustomerNumber = 5029;
            customer29.LastName = "Radkovich";
            customer29.MiddleInitial = "L";
            customer29.FirstName = "Anka";
            customer29.Birthday = new DateTime(1966, 5, 19);
            customer29.Address = "1300 Elliott Pl";
            customer29.City = "Austin";
            customer29.State = "TX";
            customer29.ZipCode = 78712;
            customer29.SSN = 3022345566;
            customer29.PhoneNumber = "5125550151";
            customer29.UserName = "ankaisrad@gogle.com";
            customer29.Email = "ankaisrad@gogle.com";
            customer29.PopcornPoints = 120;
            var resultcustomer29 = UserManager.Create(customer29, "radgirl");
            db.SaveChanges();
            customer29 = db.Users.FirstOrDefault(u => u.Email == "ankaisrad@gogle.com");
            if (UserManager.IsInRole(customer29.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer29.Id, "Customer");
            }

            AppUser customer30 = db.Users.FirstOrDefault(u => u.Email == "megrhodes@freserve.co.uk");
            customer30 = new AppUser();
            customer30.CustomerNumber = 5030;
            customer30.LastName = "Rhodes";
            customer30.MiddleInitial = "C.";
            customer30.FirstName = "Megan";
            customer30.Birthday = new DateTime(1965, 3, 12);
            customer30.Address = "4587 Enfield Rd.";
            customer30.City = "Austin";
            customer30.State = "TX";
            customer30.ZipCode = 78705;
            customer30.SSN = 9073744746;
            customer30.PhoneNumber = "5125550133";
            customer30.UserName = "megrhodes@freserve.co.uk";
            customer30.Email = "megrhodes@freserve.co.uk";
            customer30.PopcornPoints = 190;
            var resultcustomer30 = UserManager.Create(customer30, "meganr34");
            db.SaveChanges();
            customer30 = db.Users.FirstOrDefault(u => u.Email == "megrhodes@freserve.co.uk");
            if (UserManager.IsInRole(customer30.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer30.Id, "Customer");
            }

            AppUser customer31 = db.Users.FirstOrDefault(u => u.Email == "erynrice@aoll.com");
            customer31 = new AppUser();
            customer31.CustomerNumber = 5031;
            customer31.LastName = "Rice";
            customer31.MiddleInitial = "M.";
            customer31.FirstName = "Eryn";
            customer31.Birthday = new DateTime(1975, 4, 28);
            customer31.Address = "3405 Rio Grande";
            customer31.City = "Austin";
            customer31.State = "TX";
            customer31.ZipCode = 78785;
            customer31.SSN = 9073876657;
            customer31.PhoneNumber = "5125550196";
            customer31.UserName = "erynrice@aoll.com";
            customer31.Email = "erynrice@aoll.com";
            customer31.PopcornPoints = 190;
            var resultcustomer31 = UserManager.Create(customer31, "ricearoni");
            db.SaveChanges();
            customer31 = db.Users.FirstOrDefault(u => u.Email == "erynrice@aoll.com");
            if (UserManager.IsInRole(customer31.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer31.Id, "Customer");
            }

            AppUser customer32 = db.Users.FirstOrDefault(u => u.Email == "jorge@noclue.com");
            customer32 = new AppUser();
            customer32.CustomerNumber = 5032;
            customer32.LastName = "Rodriguez";
            customer32.MiddleInitial = "";
            customer32.FirstName = "Jorge";
            customer32.Birthday = new DateTime(1953, 12, 8);
            customer32.Address = "6788 Cotter Street";
            customer32.City = "Littlefield";
            customer32.State = "TX";
            customer32.ZipCode = 79339;
            customer32.SSN = 4158904374;
            customer32.PhoneNumber = "5125550141";
            customer32.UserName = "jorge@noclue.com";
            customer32.Email = "jorge@noclue.com";
            customer32.PopcornPoints = 20;
            var resultcustomer32 = UserManager.Create(customer32, "jrod2017");
            db.SaveChanges();
            customer32 = db.Users.FirstOrDefault(u => u.Email == "jorge@noclue.com");
            if (UserManager.IsInRole(customer32.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer32.Id, "Customer");
            }

            AppUser customer33 = db.Users.FirstOrDefault(u => u.Email == "mrrogers@lovelyday.com");
            customer33 = new AppUser();
            customer33.CustomerNumber = 5033;
            customer33.LastName = "Rogers";
            customer33.MiddleInitial = "B.";
            customer33.FirstName = "Allen";
            customer33.Birthday = new DateTime(1973, 4, 22);
            customer33.Address = "4965 Oak Hill";
            customer33.City = "Austin";
            customer33.State = "TX";
            customer33.ZipCode = 78733;
            customer33.SSN = 9078752943;
            customer33.PhoneNumber = "5125550189";
            customer33.UserName = "mrrogers@lovelyday.com";
            customer33.Email = "mrrogers@lovelyday.com";
            customer33.PopcornPoints = 100;
            var resultcustomer33 = UserManager.Create(customer33, "rogerthat");
            db.SaveChanges();
            customer33 = db.Users.FirstOrDefault(u => u.Email == "mrrogers@lovelyday.com");
            if (UserManager.IsInRole(customer33.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer33.Id, "Customer");
            }

            AppUser customer34 = db.Users.FirstOrDefault(u => u.Email == "stjean@athome.com");
            customer34 = new AppUser();
            customer34.CustomerNumber = 5034;
            customer34.LastName = "Saint-Jean";
            customer34.MiddleInitial = "M";
            customer34.FirstName = "Olivier";
            customer34.Birthday = new DateTime(1995, 2, 19);
            customer34.Address = "255 Toncray Dr.";
            customer34.City = "Austin";
            customer34.State = "TX";
            customer34.ZipCode = 78755;
            customer34.SSN = 3434145678;
            customer34.PhoneNumber = "5125550152";
            customer34.UserName = "stjean@athome.com";
            customer34.Email = "stjean@athome.com";
            customer34.PopcornPoints = 250;
            var resultcustomer34 = UserManager.Create(customer34, "bunnyhop");
            db.SaveChanges();
            customer34 = db.Users.FirstOrDefault(u => u.Email == "stjean@athome.com");
            if (UserManager.IsInRole(customer34.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer34.Id, "Customer");
            }

            AppUser customer35 = db.Users.FirstOrDefault(u => u.Email == "saunders@pen.com");
            customer35 = new AppUser();
            customer35.CustomerNumber = 5035;
            customer35.LastName = "Saunders";
            customer35.MiddleInitial = "J.";
            customer35.FirstName = "Sarah";
            customer35.Birthday = new DateTime(1978, 2, 19);
            customer35.Address = "332 Avenue C";
            customer35.City = "Austin";
            customer35.State = "TX";
            customer35.ZipCode = 78701;
            customer35.SSN = 9073497810;
            customer35.PhoneNumber = "5125550146";
            customer35.UserName = "saunders@pen.com";
            customer35.Email = "saunders@pen.com";
            customer35.PopcornPoints = 40;
            var resultcustomer35 = UserManager.Create(customer35, "penguin12");
            db.SaveChanges();
            customer35 = db.Users.FirstOrDefault(u => u.Email == "saunders@pen.com");
            if (UserManager.IsInRole(customer35.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer35.Id, "Customer");
            }

            AppUser customer36 = db.Users.FirstOrDefault(u => u.Email == "willsheff@email.com");
            customer36 = new AppUser();
            customer36.CustomerNumber = 5036;
            customer36.LastName = "Sewell";
            customer36.MiddleInitial = "T.";
            customer36.FirstName = "William";
            customer36.Birthday = new DateTime(2004, 12, 23);
            customer36.Address = "2365 51st St.";
            customer36.City = "El Paso";
            customer36.State = "TX";
            customer36.ZipCode = 79953;
            customer36.SSN = 9074510084;
            customer36.PhoneNumber = "5125550192";
            customer36.UserName = "willsheff@email.com";
            customer36.Email = "willsheff@email.com";
            customer36.PopcornPoints = 200;
            var resultcustomer36 = UserManager.Create(customer36, "alaskaboy");
            db.SaveChanges();
            customer36 = db.Users.FirstOrDefault(u => u.Email == "willsheff@email.com");
            if (UserManager.IsInRole(customer36.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer36.Id, "Customer");
            }

            AppUser customer37 = db.Users.FirstOrDefault(u => u.Email == "sheffiled@gogle.com");
            customer37 = new AppUser();
            customer37.CustomerNumber = 5037;
            customer37.LastName = "Sheffield";
            customer37.MiddleInitial = "J.";
            customer37.FirstName = "Martin";
            customer37.Birthday = new DateTime(1960, 5, 8);
            customer37.Address = "3886 Avenue A";
            customer37.City = "Balmorhea";
            customer37.State = "TX";
            customer37.ZipCode = 79718;
            customer37.SSN = 9075479167;
            customer37.PhoneNumber = "5125550131";
            customer37.UserName = "sheffiled@gogle.com";
            customer37.Email = "sheffiled@gogle.com";
            customer37.PopcornPoints = 130;
            var resultcustomer37 = UserManager.Create(customer37, "martin1234");
            db.SaveChanges();
            customer37 = db.Users.FirstOrDefault(u => u.Email == "sheffiled@gogle.com");
            if (UserManager.IsInRole(customer37.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer37.Id, "Customer");
            }

            AppUser customer38 = db.Users.FirstOrDefault(u => u.Email == "johnsmith187@aoll.com");
            customer38 = new AppUser();
            customer38.CustomerNumber = 5038;
            customer38.LastName = "Smith";
            customer38.MiddleInitial = "A";
            customer38.FirstName = "John";
            customer38.Birthday = new DateTime(1955, 6, 25);
            customer38.Address = "23 Hidden Forge Dr.";
            customer38.City = "Austin";
            customer38.State = "TX";
            customer38.ZipCode = 78760;
            customer38.SSN = 2838321888;
            customer38.PhoneNumber = "5125550190";
            customer38.UserName = "johnsmith187@aoll.com";
            customer38.Email = "johnsmith187@aoll.com";
            customer38.PopcornPoints = 130;
            var resultcustomer38 = UserManager.Create(customer38, "smitty444");
            db.SaveChanges();
            customer38 = db.Users.FirstOrDefault(u => u.Email == "johnsmith187@aoll.com");
            if (UserManager.IsInRole(customer38.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer38.Id, "Customer");
            }

            AppUser customer39 = db.Users.FirstOrDefault(u => u.Email == "dustroud@mail.com");
            customer39 = new AppUser();
            customer39.CustomerNumber = 5039;
            customer39.LastName = "Stroud";
            customer39.MiddleInitial = "P";
            customer39.FirstName = "Dustin";
            customer39.Birthday = new DateTime(1967, 7, 26);
            customer39.Address = "1212 Rita Rd";
            customer39.City = "Austin";
            customer39.State = "TX";
            customer39.ZipCode = 78734;
            customer39.SSN = 2172346667;
            customer39.PhoneNumber = "5125550157";
            customer39.UserName = "dustroud@mail.com";
            customer39.Email = "dustroud@mail.com";
            customer39.PopcornPoints = 90;
            var resultcustomer39 = UserManager.Create(customer39, "dustydusty");
            db.SaveChanges();
            customer39 = db.Users.FirstOrDefault(u => u.Email == "dustroud@mail.com");
            if (UserManager.IsInRole(customer39.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer39.Id, "Customer");
            }

            AppUser customer40 = db.Users.FirstOrDefault(u => u.Email == "estuart@anchor.net");
            customer40 = new AppUser();
            customer40.CustomerNumber = 5040;
            customer40.LastName = "Stuart";
            customer40.MiddleInitial = "D.";
            customer40.FirstName = "Eric";
            customer40.Birthday = new DateTime(1947, 12, 4);
            customer40.Address = "5576 Toro Ring";
            customer40.City = "Kyle";
            customer40.State = "TX";
            customer40.ZipCode = 78640;
            customer40.SSN = 9078178335;
            customer40.PhoneNumber = "5125550191";
            customer40.UserName = "estuart@anchor.net";
            customer40.Email = "estuart@anchor.net";
            customer40.PopcornPoints = 170;
            var resultcustomer40 = UserManager.Create(customer40, "stewball");
            db.SaveChanges();
            customer40 = db.Users.FirstOrDefault(u => u.Email == "estuart@anchor.net");
            if (UserManager.IsInRole(customer40.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer40.Id, "Customer");
            }

            AppUser customer41 = db.Users.FirstOrDefault(u => u.Email == "peterstump@noclue.com");
            customer41 = new AppUser();
            customer41.CustomerNumber = 5041;
            customer41.LastName = "Stump";
            customer41.MiddleInitial = "L";
            customer41.FirstName = "Peter";
            customer41.Birthday = new DateTime(1974, 7, 10);
            customer41.Address = "1300 Kellen Circle";
            customer41.City = "Philadelphia";
            customer41.State = "PA";
            customer41.ZipCode = 19123;
            customer41.SSN = 2084560903;
            customer41.PhoneNumber = "5125550136";
            customer41.UserName = "peterstump@noclue.com";
            customer41.Email = "peterstump@noclue.com";
            customer41.PopcornPoints = 50;
            var resultcustomer41 = UserManager.Create(customer41, "slowwind");
            db.SaveChanges();
            customer41 = db.Users.FirstOrDefault(u => u.Email == "peterstump@noclue.com");
            if (UserManager.IsInRole(customer41.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer41.Id, "Customer");
            }

            AppUser customer42 = db.Users.FirstOrDefault(u => u.Email == "jtanner@mustang.net");
            customer42 = new AppUser();
            customer42.CustomerNumber = 5042;
            customer42.LastName = "Tanner";
            customer42.MiddleInitial = "S.";
            customer42.FirstName = "Jeremy";
            customer42.Birthday = new DateTime(1944, 1, 11);
            customer42.Address = "4347 Almstead";
            customer42.City = "Austin";
            customer42.State = "TX";
            customer42.ZipCode = 78747;
            customer42.SSN = 9074590929;
            customer42.PhoneNumber = "5125550170";
            customer42.UserName = "jtanner@mustang.net";
            customer42.Email = "jtanner@mustang.net";
            customer42.PopcornPoints = 190;
            var resultcustomer42 = UserManager.Create(customer42, "tanner5454");
            db.SaveChanges();
            customer42 = db.Users.FirstOrDefault(u => u.Email == "jtanner@mustang.net");
            if (UserManager.IsInRole(customer42.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer42.Id, "Customer");
            }

            AppUser customer43 = db.Users.FirstOrDefault(u => u.Email == "taylordjay@aoll.com");
            customer43 = new AppUser();
            customer43.CustomerNumber = 5043;
            customer43.LastName = "Taylor";
            customer43.MiddleInitial = "R.";
            customer43.FirstName = "Allison";
            customer43.Birthday = new DateTime(1990, 11, 14);
            customer43.Address = "467 Nueces St.";
            customer43.City = "Austin";
            customer43.State = "TX";
            customer43.ZipCode = 78712;
            customer43.SSN = 9074748452;
            customer43.PhoneNumber = "5125550160";
            customer43.UserName = "taylordjay@aoll.com";
            customer43.Email = "taylordjay@aoll.com";
            customer43.PopcornPoints = 110;
            var resultcustomer43 = UserManager.Create(customer43, "allyrally");
            db.SaveChanges();
            customer43 = db.Users.FirstOrDefault(u => u.Email == "taylordjay@aoll.com");
            if (UserManager.IsInRole(customer43.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer43.Id, "Customer");
            }

            AppUser customer44 = db.Users.FirstOrDefault(u => u.Email == "rtaylor@gogle.com");
            customer44 = new AppUser();
            customer44.CustomerNumber = 5044;
            customer44.LastName = "Taylor";
            customer44.MiddleInitial = "K.";
            customer44.FirstName = "Rachel";
            customer44.Birthday = new DateTime(1976, 1, 18);
            customer44.Address = "345 Longview Dr.";
            customer44.City = "Austin";
            customer44.State = "TX";
            customer44.ZipCode = 78758;
            customer44.SSN = 9074907631;
            customer44.PhoneNumber = "5125550127";
            customer44.UserName = "rtaylor@gogle.com";
            customer44.Email = "rtaylor@gogle.com";
            customer44.PopcornPoints = 160;
            var resultcustomer44 = UserManager.Create(customer44, "taylorbaylor");
            db.SaveChanges();
            customer44 = db.Users.FirstOrDefault(u => u.Email == "rtaylor@gogle.com");
            if (UserManager.IsInRole(customer44.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer44.Id, "Customer");
            }

            AppUser customer45 = db.Users.FirstOrDefault(u => u.Email == "teefrank@noclue.com");
            customer45 = new AppUser();
            customer45.CustomerNumber = 5045;
            customer45.LastName = "Tee";
            customer45.MiddleInitial = "J";
            customer45.FirstName = "Frank";
            customer45.Birthday = new DateTime(1998, 9, 6);
            customer45.Address = "5590 Lavell Dr";
            customer45.City = "Austin";
            customer45.State = "TX";
            customer45.ZipCode = 78729;
            customer45.SSN = 2138765543;
            customer45.PhoneNumber = "5125550161";
            customer45.UserName = "teefrank@noclue.com";
            customer45.Email = "teefrank@noclue.com";
            customer45.PopcornPoints = 70;
            var resultcustomer45 = UserManager.Create(customer45, "teeoff22");
            db.SaveChanges();
            customer45 = db.Users.FirstOrDefault(u => u.Email == "teefrank@noclue.com");
            if (UserManager.IsInRole(customer45.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer45.Id, "Customer");
            }

            AppUser customer46 = db.Users.FirstOrDefault(u => u.Email == "ctucker@alphabet.co.uk");
            customer46 = new AppUser();
            customer46.CustomerNumber = 5046;
            customer46.LastName = "Tucker";
            customer46.MiddleInitial = "J";
            customer46.FirstName = "Clent";
            customer46.Birthday = new DateTime(1943, 2, 25);
            customer46.Address = "312 Main St.";
            customer46.City = "Round Rock";
            customer46.State = "TX";
            customer46.ZipCode = 78665;
            customer46.SSN = 9038471154;
            customer46.PhoneNumber = "5125550106";
            customer46.UserName = "ctucker@alphabet.co.uk";
            customer46.Email = "ctucker@alphabet.co.uk";
            customer46.PopcornPoints = 150;
            var resultcustomer46 = UserManager.Create(customer46, "tucksack1");
            db.SaveChanges();
            customer46 = db.Users.FirstOrDefault(u => u.Email == "ctucker@alphabet.co.uk");
            if (UserManager.IsInRole(customer46.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer46.Id, "Customer");
            }

            AppUser customer47 = db.Users.FirstOrDefault(u => u.Email == "avelasco@yoho.com");
            customer47 = new AppUser();
            customer47.CustomerNumber = 5047;
            customer47.LastName = "Velasco";
            customer47.MiddleInitial = "G";
            customer47.FirstName = "Allen";
            customer47.Birthday = new DateTime(1985, 9, 10);
            customer47.Address = "679 W. 4th";
            customer47.City = "Cedar Park";
            customer47.State = "TX";
            customer47.ZipCode = 78613;
            customer47.SSN = 3103985638;
            customer47.PhoneNumber = "5125550170";
            customer47.UserName = "avelasco@yoho.com";
            customer47.Email = "avelasco@yoho.com";
            customer47.PopcornPoints = 0;
            var resultcustomer47 = UserManager.Create(customer47, "meow88");
            db.SaveChanges();
            customer47 = db.Users.FirstOrDefault(u => u.Email == "avelasco@yoho.com");
            if (UserManager.IsInRole(customer47.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer47.Id, "Customer");
            }

            AppUser customer48 = db.Users.FirstOrDefault(u => u.Email == "vinovino@grapes.com");
            customer48 = new AppUser();
            customer48.CustomerNumber = 5048;
            customer48.LastName = "Vino";
            customer48.MiddleInitial = "E";
            customer48.FirstName = "Janet";
            customer48.Birthday = new DateTime(1985, 2, 7);
            customer48.Address = "189 Grape Road";
            customer48.City = "Lockhart";
            customer48.State = "TX";
            customer48.ZipCode = 78644;
            customer48.SSN = 8175643832;
            customer48.PhoneNumber = "5125550128";
            customer48.UserName = "vinovino@grapes.com";
            customer48.Email = "vinovino@grapes.com";
            customer48.PopcornPoints = 160;
            var resultcustomer48 = UserManager.Create(customer48, "vinovino");
            db.SaveChanges();
            customer48 = db.Users.FirstOrDefault(u => u.Email == "vinovino@grapes.com");
            if (UserManager.IsInRole(customer48.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer48.Id, "Customer");
            }

            AppUser customer49 = db.Users.FirstOrDefault(u => u.Email == "westj@pioneer.net");
            customer49 = new AppUser();
            customer49.CustomerNumber = 5049;
            customer49.LastName = "West";
            customer49.MiddleInitial = "T";
            customer49.FirstName = "Jake";
            customer49.Birthday = new DateTime(1976, 1, 9);
            customer49.Address = "RR 3287";
            customer49.City = "Austin";
            customer49.State = "TX";
            customer49.ZipCode = 78705;
            customer49.SSN = 5938475244;
            customer49.PhoneNumber = "2025550170";
            customer49.UserName = "westj@pioneer.net";
            customer49.Email = "westj@pioneer.net";
            customer49.PopcornPoints = 70;
            var resultcustomer49 = UserManager.Create(customer49, "gowest");
            db.SaveChanges();
            customer49 = db.Users.FirstOrDefault(u => u.Email == "westj@pioneer.net");
            if (UserManager.IsInRole(customer49.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer49.Id, "Customer");
            }

            AppUser customer50 = db.Users.FirstOrDefault(u => u.Email == "winner@hootmail.com");
            customer50 = new AppUser();
            customer50.CustomerNumber = 5050;
            customer50.LastName = "Winthorpe";
            customer50.MiddleInitial = "L";
            customer50.FirstName = "Louis";
            customer50.Birthday = new DateTime(1953, 4, 19);
            customer50.Address = "2500 Padre Blvd";
            customer50.City = "Austin";
            customer50.State = "TX";
            customer50.ZipCode = 78747;
            customer50.SSN = 2105650098;
            customer50.PhoneNumber = "2025550141";
            customer50.UserName = "winner@hootmail.com";
            customer50.Email = "winner@hootmail.com";
            customer50.PopcornPoints = 150;
            var resultcustomer50 = UserManager.Create(customer50, "louielouie");
            db.SaveChanges();
            customer50 = db.Users.FirstOrDefault(u => u.Email == "winner@hootmail.com");
            if (UserManager.IsInRole(customer50.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer50.Id, "Customer");
            }

            AppUser customer51 = db.Users.FirstOrDefault(u => u.Email == "rwood@voyager.net");
            customer51 = new AppUser();
            customer51.CustomerNumber = 5051;
            customer51.LastName = "Wood";
            customer51.MiddleInitial = "B.";
            customer51.FirstName = "Reagan";
            customer51.Birthday = new DateTime(2002, 12, 28);
            customer51.Address = "447 Westlake Dr.";
            customer51.City = "Austin";
            customer51.State = "TX";
            customer51.ZipCode = 78753;
            customer51.SSN = 9074545242;
            customer51.PhoneNumber = "2025550128";
            customer51.UserName = "rwood@voyager.net";
            customer51.Email = "rwood@voyager.net";
            customer51.PopcornPoints = 20;
            var resultcustomer51 = UserManager.Create(customer51, "woodyman1");
            db.SaveChanges();
            customer51 = db.Users.FirstOrDefault(u => u.Email == "rwood@voyager.net");
            if (UserManager.IsInRole(customer51.Id, "Customer") == false)
            {
                UserManager.AddToRole(customer51.Id, "Customer");
            }

            db.SaveChanges();
        }
    }
}
