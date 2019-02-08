using Microsoft.AspNet.Identity;
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
    public class SeedEmployees
    {
        public void AddEmployees(AppDbContext db)
        {
            //create a user manager and a role manager to use for this method
            AppUserManager UserManager = new AppUserManager(new UserStore<AppUser>(db));
            
            

            AppUser Manager1 = db.Users.FirstOrDefault(u => u.Email == "e.rice@longhorncinema.com");
            Manager1 = new AppUser();
            Manager1.LastName = "Rice";
            Manager1.MiddleInitial = "M";
            Manager1.FirstName = "Eryn";
            Manager1.Birthday = new DateTime(1959, 7, 2);
            Manager1.Address = "3405 Rio Grande";
            Manager1.City = "Austin";
            Manager1.State = "TX";
            Manager1.ZipCode = 78746;
            Manager1.SSN = 454776657;
            Manager1.PhoneNumber = "9073876657";
            Manager1.UserName = "e.rice@longhorncinema.com";
            Manager1.Email = "e.rice@longhorncinema.com";
            var resultManager1 = UserManager.Create(Manager1, "ricearoni");
            db.SaveChanges();
            Manager1 = db.Users.FirstOrDefault(u => u.Email == "e.rice@longhorncinema.com");
            if (UserManager.IsInRole(Manager1.Id, "Manager") == false)
            {
                UserManager.AddToRole(Manager1.Id, "Manager");
            }

            AppUser Manager2 = db.Users.FirstOrDefault(u => u.Email == "r.taylor@longhorncinema.com");
            Manager2 = new AppUser();
            Manager2.LastName = "Taylor";
            Manager2.MiddleInitial = "O";
            Manager2.FirstName = "Rachel";
            Manager2.Birthday = new DateTime(1972, 12, 20);
            Manager2.Address = "345 Longview Dr.";
            Manager2.City = "Austin";
            Manager2.State = "TX";
            Manager2.ZipCode = 78746;
            Manager2.SSN = 393412631;
            Manager2.PhoneNumber = "9074512631";
            Manager2.UserName = "r.taylor@longhorncinema.com";
            Manager2.Email = "r.taylor@longhorncinema.com";
            var resultManager2 = UserManager.Create(Manager2, "swansong");
            db.SaveChanges();
            Manager2 = db.Users.FirstOrDefault(u => u.Email == "r.taylor@longhorncinema.com");
            if (UserManager.IsInRole(Manager2.Id, "Manager") == false)
            {
                UserManager.AddToRole(Manager2.Id, "Manager");
            }

            AppUser Manager3 = db.Users.FirstOrDefault(u => u.Email == "a.rogers@longhorncinema.com");
            Manager3 = new AppUser();
            Manager3.LastName = "Rogers";
            Manager3.MiddleInitial = "H";
            Manager3.FirstName = "Allen";
            Manager3.Birthday = new DateTime(1978, 6, 21);
            Manager3.Address = "4965 Oak Hill";
            Manager3.City = "Austin";
            Manager3.State = "TX";
            Manager3.ZipCode = 78705;
            Manager3.SSN = 700002943;
            Manager3.PhoneNumber = "9078752943";
            Manager3.UserName = "a.rogers@longhorncinema.com";
            Manager3.Email = "a.rogers@longhorncinema.com";
            var resultManager3 = UserManager.Create(Manager3, "evanescent");
            db.SaveChanges();
            Manager3 = db.Users.FirstOrDefault(u => u.Email == "a.rogers@longhorncinema.com");
            if (UserManager.IsInRole(Manager3.Id, "Manager") == false)
            {
                UserManager.AddToRole(Manager3.Id, "Manager");
            }

            AppUser Manager4 = db.Users.FirstOrDefault(u => u.Email == "w.sewell@longhorncinema.com");
            Manager4 = new AppUser();
            Manager4.LastName = "Sewell";
            Manager4.MiddleInitial = "G";
            Manager4.FirstName = "William";
            Manager4.Birthday = new DateTime(1986, 5, 25);
            Manager4.Address = "2365 51st St.";
            Manager4.City = "Austin";
            Manager4.State = "TX";
            Manager4.ZipCode = 78755;
            Manager4.SSN = 500830084;
            Manager4.PhoneNumber = "9074510084";
            Manager4.UserName = "w.sewell@longhorncinema.com";
            Manager4.Email = "w.sewell@longhorncinema.com";
            var resultManager4 = UserManager.Create(Manager4, "walkamile");
            db.SaveChanges();
            Manager4 = db.Users.FirstOrDefault(u => u.Email == "w.sewell@longhorncinema.com");
            if (UserManager.IsInRole(Manager4.Id, "Manager") == false)
            {
                UserManager.AddToRole(Manager4.Id, "Manager");
            }

            AppUser Employee1 = db.Users.FirstOrDefault(u => u.Email == "t.jacobs@longhorncinema.com");
            Employee1 = new AppUser();
            Employee1.LastName = "Jacobs";
            Employee1.MiddleInitial = "L";
            Employee1.FirstName = "Todd";
            Employee1.Birthday = new DateTime(1958, 4, 25);
            Employee1.Address = "4564 Elm St.";
            Employee1.City = "Georgetown";
            Employee1.State = "TX";
            Employee1.ZipCode = 78628;
            Employee1.SSN = 341553365;
            Employee1.PhoneNumber = "9074653365";
            Employee1.UserName = "t.jacobs@longhorncinema.com";
            Employee1.Email = "t.jacobs@longhorncinema.com";
            var resultEmployee1 = UserManager.Create(Employee1, "society");
            db.SaveChanges();
            Employee1 = db.Users.FirstOrDefault(u => u.Email == "t.jacobs@longhorncinema.com");
            if (UserManager.IsInRole(Employee1.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee1.Id, "Employee");
            }

            AppUser Employee2 = db.Users.FirstOrDefault(u => u.Email == "b.ingram@longhorncinema.com");
            Employee2 = new AppUser();
            Employee2.LastName = "Ingram";
            Employee2.MiddleInitial = "S";
            Employee2.FirstName = "Brad";
            Employee2.Birthday = new DateTime(1962, 8, 25);
            Employee2.Address = "6548 La Posada Ct.";
            Employee2.City = "Austin";
            Employee2.State = "TX";
            Employee2.ZipCode = 78705;
            Employee2.SSN = 797348821;
            Employee2.PhoneNumber = "9074678821";
            Employee2.UserName = "b.ingram@longhorncinema.com";
            Employee2.Email = "b.ingram@longhorncinema.com";
            var resultEmployee2 = UserManager.Create(Employee2, "ingram45");
            db.SaveChanges();
            Employee2 = db.Users.FirstOrDefault(u => u.Email == "b.ingram@longhorncinema.com");
            if (UserManager.IsInRole(Employee2.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee2.Id, "Employee");
            }

            AppUser Employee3 = db.Users.FirstOrDefault(u => u.Email == "a.taylor@longhorncinema.com");
            Employee3 = new AppUser();
            Employee3.LastName = "Taylor";
            Employee3.MiddleInitial = "R";
            Employee3.FirstName = "Allison";
            Employee3.Birthday = new DateTime(1964, 9, 2);
            Employee3.Address = "467 Nueces St.";
            Employee3.City = "Austin";
            Employee3.State = "TX";
            Employee3.ZipCode = 78727;
            Employee3.SSN = 934778452;
            Employee3.PhoneNumber = "9074748452";
            Employee3.UserName = "a.taylor@longhorncinema.com";
            Employee3.Email = "a.taylor@longhorncinema.com";
            var resultEmployee3 = UserManager.Create(Employee3, "nostalgic");
            db.SaveChanges();
            Employee3 = db.Users.FirstOrDefault(u => u.Email == "a.taylor@longhorncinema.com");
            if (UserManager.IsInRole(Employee3.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee3.Id, "Employee");
            }

            AppUser Employee4 = db.Users.FirstOrDefault(u => u.Email == "g.martinez@longhorncinema.com");
            Employee4 = new AppUser();
            Employee4.LastName = "Martinez";
            Employee4.MiddleInitial = "R";
            Employee4.FirstName = "Gregory";
            Employee4.Birthday = new DateTime(1992, 3, 30);
            Employee4.Address = "8295 Sunset Blvd.";
            Employee4.City = "Austin";
            Employee4.State = "TX";
            Employee4.ZipCode = 78712;
            Employee4.SSN = 463566718;
            Employee4.PhoneNumber = "9078746718";
            Employee4.UserName = "g.martinez@longhorncinema.com";
            Employee4.Email = "g.martinez@longhorncinema.com";
            var resultEmployee4 = UserManager.Create(Employee4, "fungus");
            db.SaveChanges();
            Employee4 = db.Users.FirstOrDefault(u => u.Email == "g.martinez@longhorncinema.com");
            if (UserManager.IsInRole(Employee4.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee4.Id, "Employee");
            }

            AppUser Employee5 = db.Users.FirstOrDefault(u => u.Email == "m.sheffield@longhorncinema.com");
            Employee5 = new AppUser();
            Employee5.LastName = "Sheffield";
            Employee5.MiddleInitial = "J";
            Employee5.FirstName = "Martin";
            Employee5.Birthday = new DateTime(1996, 12, 29);
            Employee5.Address = "3886 Avenue A";
            Employee5.City = "San Marcos";
            Employee5.State = "TX";
            Employee5.ZipCode = 78666;
            Employee5.SSN = 223449167;
            Employee5.PhoneNumber = "9075479167";
            Employee5.UserName = "m.sheffield@longhorncinema.com";
            Employee5.Email = "m.sheffield@longhorncinema.com";
            var resultEmployee5 = UserManager.Create(Employee5, "longhorns");
            db.SaveChanges();
            Employee5 = db.Users.FirstOrDefault(u => u.Email == "m.sheffield@longhorncinema.com");
            if (UserManager.IsInRole(Employee5.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee5.Id, "Employee");
            }

            AppUser Employee6 = db.Users.FirstOrDefault(u => u.Email == "j.macleod@longhorncinema.com");
            Employee6 = new AppUser();
            Employee6.LastName = "MacLeod";
            Employee6.MiddleInitial = "D";
            Employee6.FirstName = "Jennifer";
            Employee6.Birthday = new DateTime(1997, 6, 10);
            Employee6.Address = "2504 Far West Blvd.";
            Employee6.City = "Austin";
            Employee6.State = "TX";
            Employee6.ZipCode = 78705;
            Employee6.SSN = 775908138;
            Employee6.PhoneNumber = "9074748138";
            Employee6.UserName = "j.macleod@longhorncinema.com";
            Employee6.Email = "j.macleod@longhorncinema.com";
            var resultEmployee6 = UserManager.Create(Employee6, "smitty");
            db.SaveChanges();
            Employee6 = db.Users.FirstOrDefault(u => u.Email == "j.macleod@longhorncinema.com");
            if (UserManager.IsInRole(Employee6.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee6.Id, "Employee");
            }

            AppUser Employee7 = db.Users.FirstOrDefault(u => u.Email == "j.tanner@longhorncinema.com");
            Employee7 = new AppUser();
            Employee7.LastName = "Tanner";
            Employee7.MiddleInitial = "S";
            Employee7.FirstName = "Jeremy";
            Employee7.Birthday = new DateTime(1970, 8, 12);
            Employee7.Address = "4347 Almstead";
            Employee7.City = "Austin";
            Employee7.State = "TX";
            Employee7.ZipCode = 78712;
            Employee7.SSN = 904440929;
            Employee7.PhoneNumber = "9074590929";
            Employee7.UserName = "j.tanner@longhorncinema.com";
            Employee7.Email = "j.tanner@longhorncinema.com";
            var resultEmployee7 = UserManager.Create(Employee7, "tanman");
            db.SaveChanges();
            Employee7 = db.Users.FirstOrDefault(u => u.Email == "j.tanner@longhorncinema.com");
            if (UserManager.IsInRole(Employee7.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee7.Id, "Employee");
            }

            AppUser Employee8 = db.Users.FirstOrDefault(u => u.Email == "m.rhodes@longhorncinema.com");
            Employee8 = new AppUser();
            Employee8.LastName = "Rhodes";
            Employee8.MiddleInitial = "C";
            Employee8.FirstName = "Megan";
            Employee8.Birthday = new DateTime(1970, 12, 18);
            Employee8.Address = "4587 Enfield Rd.";
            Employee8.City = "Austin";
            Employee8.State = "TX";
            Employee8.ZipCode = 78729;
            Employee8.SSN = 353904746;
            Employee8.PhoneNumber = "9073744746";
            Employee8.UserName = "m.rhodes@longhorncinema.com";
            Employee8.Email = "m.rhodes@longhorncinema.com";
            var resultEmployee8 = UserManager.Create(Employee8, "countryrhodes");
            db.SaveChanges();
            Employee8 = db.Users.FirstOrDefault(u => u.Email == "m.rhodes@longhorncinema.com");
            if (UserManager.IsInRole(Employee8.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee8.Id, "Employee");
            }

            AppUser Employee9 = db.Users.FirstOrDefault(u => u.Email == "e.stuart@longhorncinema.com");
            Employee9 = new AppUser();
            Employee9.LastName = "Stuart";
            Employee9.MiddleInitial = "F";
            Employee9.FirstName = "Eric";
            Employee9.Birthday = new DateTime(1971, 3, 11);
            Employee9.Address = "5576 Toro Ring";
            Employee9.City = "Austin";
            Employee9.State = "TX";
            Employee9.ZipCode = 78758;
            Employee9.SSN = 363998335;
            Employee9.PhoneNumber = "9078178335";
            Employee9.UserName = "e.stuart@longhorncinema.com";
            Employee9.Email = "e.stuart@longhorncinema.com";
            var resultEmployee9 = UserManager.Create(Employee9, "stewboy");
            db.SaveChanges();
            Employee9 = db.Users.FirstOrDefault(u => u.Email == "e.stuart@longhorncinema.com");
            if (UserManager.IsInRole(Employee9.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee9.Id, "Employee");
            }

            AppUser Employee10 = db.Users.FirstOrDefault(u => u.Email == "c.miller@longhorncinema.com");
            Employee10 = new AppUser();
            Employee10.LastName = "Miller";
            Employee10.MiddleInitial = "R";
            Employee10.FirstName = "Charles";
            Employee10.Birthday = new DateTime(1972, 7, 20);
            Employee10.Address = "8962 Main St.";
            Employee10.City = "Austin";
            Employee10.State = "TX";
            Employee10.ZipCode = 78709;
            Employee10.SSN = 353308615;
            Employee10.PhoneNumber = "9077458615";
            Employee10.UserName = "c.miller@longhorncinema.com";
            Employee10.Email = "c.miller@longhorncinema.com";
            var resultEmployee10 = UserManager.Create(Employee10, "squirrel");
            db.SaveChanges();
            Employee10 = db.Users.FirstOrDefault(u => u.Email == "c.miller@longhorncinema.com");
            if (UserManager.IsInRole(Employee10.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee10.Id, "Employee");
            }

            AppUser Employee11 = db.Users.FirstOrDefault(u => u.Email == "v.lawrence@longhorncinema.com");
            Employee11 = new AppUser();
            Employee11.LastName = "Lawrence";
            Employee11.MiddleInitial = "Y";
            Employee11.FirstName = "Victoria";
            Employee11.Birthday = new DateTime(1973, 4, 28);
            Employee11.Address = "6639 Butterfly Ln.";
            Employee11.City = "Austin";
            Employee11.State = "TX";
            Employee11.ZipCode = 78712;
            Employee11.SSN = 770097399;
            Employee11.PhoneNumber = "9079457399";
            Employee11.UserName = "v.lawrence@longhorncinema.com";
            Employee11.Email = "v.lawrence@longhorncinema.com";
            var resultEmployee11 = UserManager.Create(Employee11, "lottery");
            db.SaveChanges();
            Employee11 = db.Users.FirstOrDefault(u => u.Email == "v.lawrence@longhorncinema.com");
            if (UserManager.IsInRole(Employee11.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee11.Id, "Employee");
            }

            AppUser Employee12 = db.Users.FirstOrDefault(u => u.Email == "e.markham@longhorncinema.com");
            Employee12 = new AppUser();
            Employee12.LastName = "Markham";
            Employee12.MiddleInitial = "K";
            Employee12.FirstName = "Elizabeth";
            Employee12.Birthday = new DateTime(1990, 5, 21);
            Employee12.Address = "7861 Chevy Chase";
            Employee12.City = "Austin";
            Employee12.State = "TX";
            Employee12.ZipCode = 78785;
            Employee12.SSN = 101529845;
            Employee12.PhoneNumber = "9074579845";
            Employee12.UserName = "e.markham@longhorncinema.com";
            Employee12.Email = "e.markham@longhorncinema.com";
            var resultEmployee12 = UserManager.Create(Employee12, "monty3");
            db.SaveChanges();
            Employee12 = db.Users.FirstOrDefault(u => u.Email == "e.markham@longhorncinema.com");
            if (UserManager.IsInRole(Employee12.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee12.Id, "Employee");
            }

            AppUser Employee13 = db.Users.FirstOrDefault(u => u.Email == "c.baker@longhorncinema.com");
            Employee13 = new AppUser();
            Employee13.LastName = "Baker";
            Employee13.MiddleInitial = "E";
            Employee13.FirstName = "Christopher";
            Employee13.Birthday = new DateTime(1993, 3, 16);
            Employee13.Address = "1245 Lake Anchorage Blvd.";
            Employee13.City = "Cedar Park";
            Employee13.State = "TX";
            Employee13.ZipCode = 78613;
            Employee13.SSN = 401661146;
            Employee13.PhoneNumber = "9075571146";
            Employee13.UserName = "c.baker@longhorncinema.com";
            Employee13.Email = "c.baker@longhorncinema.com";
            var resultEmployee13 = UserManager.Create(Employee13, "hecktour");
            db.SaveChanges();
            Employee13 = db.Users.FirstOrDefault(u => u.Email == "c.baker@longhorncinema.com");
            if (UserManager.IsInRole(Employee13.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee13.Id, "Employee");
            }

            AppUser Employee14 = db.Users.FirstOrDefault(u => u.Email == "s.saunders@longhorncinema.com");
            Employee14 = new AppUser();
            Employee14.LastName = "Saunders";
            Employee14.MiddleInitial = "M";
            Employee14.FirstName = "Sarah";
            Employee14.Birthday = new DateTime(1997, 1, 5);
            Employee14.Address = "332 Avenue C";
            Employee14.City = "Austin";
            Employee14.State = "TX";
            Employee14.ZipCode = 78733;
            Employee14.SSN = 500987810;
            Employee14.PhoneNumber = "9073497810";
            Employee14.UserName = "s.saunders@longhorncinema.com";
            Employee14.Email = "s.saunders@longhorncinema.com";
            var resultEmployee14 = UserManager.Create(Employee14, "rankmary");
            db.SaveChanges();
            Employee14 = db.Users.FirstOrDefault(u => u.Email == "s.saunders@longhorncinema.com");
            if (UserManager.IsInRole(Employee14.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee14.Id, "Employee");
            }

            AppUser Employee15 = db.Users.FirstOrDefault(u => u.Email == "j.mason@longhorncinema.com");
            Employee15 = new AppUser();
            Employee15.LastName = "Mason";
            Employee15.MiddleInitial = "L";
            Employee15.FirstName = "Jack";
            Employee15.Birthday = new DateTime(1986, 6, 6);
            Employee15.Address = "444 45th St";
            Employee15.City = "Austin";
            Employee15.State = "TX";
            Employee15.ZipCode = 78701;
            Employee15.SSN = 1112223232;
            Employee15.PhoneNumber = "9018833432";
            Employee15.UserName = "j.mason@longhorncinema.com";
            Employee15.Email = "j.mason@longhorncinema.com";
            var resultEmployee15 = UserManager.Create(Employee15, "changalang");
            db.SaveChanges();
            Employee15 = db.Users.FirstOrDefault(u => u.Email == "j.mason@longhorncinema.com");
            if (UserManager.IsInRole(Employee15.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee15.Id, "Employee");
            }

            AppUser Employee16 = db.Users.FirstOrDefault(u => u.Email == "j.jackson@longhorncinema.com");
            Employee16 = new AppUser();
            Employee16.LastName = "Jackson";
            Employee16.MiddleInitial = "J";
            Employee16.FirstName = "Jack";
            Employee16.Birthday = new DateTime(1986, 10, 16);
            Employee16.Address = "222 Main";
            Employee16.City = "Austin";
            Employee16.State = "TX";
            Employee16.ZipCode = 78760;
            Employee16.SSN = 8889993434;
            Employee16.PhoneNumber = "9075554545";
            Employee16.UserName = "j.jackson@longhorncinema.com";
            Employee16.Email = "j.jackson@longhorncinema.com";
            var resultEmployee16 = UserManager.Create(Employee16, "offbeat");
            db.SaveChanges();
            Employee16 = db.Users.FirstOrDefault(u => u.Email == "j.jackson@longhorncinema.com");
            if (UserManager.IsInRole(Employee16.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee16.Id, "Employee");
            }

            AppUser Employee17 = db.Users.FirstOrDefault(u => u.Email == "m.nguyen@longhorncinema.com");
            Employee17 = new AppUser();
            Employee17.LastName = "Nguyen";
            Employee17.MiddleInitial = "J";
            Employee17.FirstName = "Mary";
            Employee17.Birthday = new DateTime(1988, 4, 5);
            Employee17.Address = "465 N. Bear Cub";
            Employee17.City = "Austin";
            Employee17.State = "TX";
            Employee17.ZipCode = 78734;
            Employee17.SSN = 7776665555;
            Employee17.PhoneNumber = "9075524141";
            Employee17.UserName = "m.nguyen@longhorncinema.com";
            Employee17.Email = "m.nguyen@longhorncinema.com";
            var resultEmployee17 = UserManager.Create(Employee17, "landus");
            db.SaveChanges();
            Employee17 = db.Users.FirstOrDefault(u => u.Email == "m.nguyen@longhorncinema.com");
            if (UserManager.IsInRole(Employee17.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee17.Id, "Employee");
            }

            AppUser Employee18 = db.Users.FirstOrDefault(u => u.Email == "s.barnes@longhorncinema.com");
            Employee18 = new AppUser();
            Employee18.LastName = "Barnes";
            Employee18.MiddleInitial = "M";
            Employee18.FirstName = "Susan";
            Employee18.Birthday = new DateTime(1993, 2, 22);
            Employee18.Address = "888 S. Main";
            Employee18.City = "Kyle";
            Employee18.State = "TX";
            Employee18.ZipCode = 78640;
            Employee18.SSN = 1112221212;
            Employee18.PhoneNumber = "9556662323";
            Employee18.UserName = "s.barnes@longhorncinema.com";
            Employee18.Email = "s.barnes@longhorncinema.com";
            var resultEmployee18 = UserManager.Create(Employee18, "rhythm");
            db.SaveChanges();
            Employee18 = db.Users.FirstOrDefault(u => u.Email == "s.barnes@longhorncinema.com");
            if (UserManager.IsInRole(Employee18.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee18.Id, "Employee");
            }

            AppUser Employee19 = db.Users.FirstOrDefault(u => u.Email == "l.jones@longhorncinema.com");
            Employee19 = new AppUser();
            Employee19.LastName = "Jones";
            Employee19.MiddleInitial = "L";
            Employee19.FirstName = "Lester";
            Employee19.Birthday = new DateTime(1996, 6, 29);
            Employee19.Address = "999 LeBlat";
            Employee19.City = "Austin";
            Employee19.State = "TX";
            Employee19.ZipCode = 78747;
            Employee19.SSN = 9099099999;
            Employee19.PhoneNumber = "9886662222";
            Employee19.UserName = "l.jones@longhorncinema.com";
            Employee19.Email = "l.jones@longhorncinema.com";
            var resultEmployee19 = UserManager.Create(Employee19, "kindly");
            db.SaveChanges();
            Employee19 = db.Users.FirstOrDefault(u => u.Email == "l.jones@longhorncinema.com");
            if (UserManager.IsInRole(Employee19.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee19.Id, "Employee");
            }

            AppUser Employee20 = db.Users.FirstOrDefault(u => u.Email == "h.garcia@longhorncinema.com");
            Employee20 = new AppUser();
            Employee20.LastName = "Garcia";
            Employee20.MiddleInitial = "W";
            Employee20.FirstName = "Hector";
            Employee20.Birthday = new DateTime(1997, 5, 13);
            Employee20.Address = "777 PBR Drive";
            Employee20.City = "Austin";
            Employee20.State = "TX";
            Employee20.ZipCode = 78712;
            Employee20.SSN = 4445554343;
            Employee20.PhoneNumber = "9221114444";
            Employee20.UserName = "h.garcia@longhorncinema.com";
            Employee20.Email = "h.garcia@longhorncinema.com";
            var resultEmployee20 = UserManager.Create(Employee20, "instrument");
            db.SaveChanges();
            Employee20 = db.Users.FirstOrDefault(u => u.Email == "h.garcia@longhorncinema.com");
            if (UserManager.IsInRole(Employee20.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee20.Id, "Employee");
            }

            AppUser Employee21 = db.Users.FirstOrDefault(u => u.Email == "c.silva@longhorncinema.com");
            Employee21 = new AppUser();
            Employee21.LastName = "Silva";
            Employee21.MiddleInitial = "S";
            Employee21.FirstName = "Cindy";
            Employee21.Birthday = new DateTime(1997, 12, 29);
            Employee21.Address = "900 4th St";
            Employee21.City = "Austin";
            Employee21.State = "TX";
            Employee21.ZipCode = 78758;
            Employee21.SSN = 7776661111;
            Employee21.PhoneNumber = "9221113333";
            Employee21.UserName = "c.silva@longhorncinema.com";
            Employee21.Email = "c.silva@longhorncinema.com";
            var resultEmployee21 = UserManager.Create(Employee21, "arched");
            db.SaveChanges();
            Employee21 = db.Users.FirstOrDefault(u => u.Email == "c.silva@longhorncinema.com");
            if (UserManager.IsInRole(Employee21.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee21.Id, "Employee");
            }

            AppUser Employee22 = db.Users.FirstOrDefault(u => u.Email == "m.lopez@longhorncinema.com");
            Employee22 = new AppUser();
            Employee22.LastName = "Lopez";
            Employee22.MiddleInitial = "T";
            Employee22.FirstName = "Marshall";
            Employee22.Birthday = new DateTime(1996, 11, 4);
            Employee22.Address = "90 SW North St";
            Employee22.City = "Austin";
            Employee22.State = "TX";
            Employee22.ZipCode = 78729;
            Employee22.SSN = 2223332222;
            Employee22.PhoneNumber = "9234442222";
            Employee22.UserName = "m.lopez@longhorncinema.com";
            Employee22.Email = "m.lopez@longhorncinema.com";
            var resultEmployee22 = UserManager.Create(Employee22, "median");
            db.SaveChanges();
            Employee22 = db.Users.FirstOrDefault(u => u.Email == "m.lopez@longhorncinema.com");
            if (UserManager.IsInRole(Employee22.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee22.Id, "Employee");
            }

            AppUser Employee23 = db.Users.FirstOrDefault(u => u.Email == "b.larson@longhorncinema.com");
            Employee23 = new AppUser();
            Employee23.LastName = "Larson";
            Employee23.MiddleInitial = "B";
            Employee23.FirstName = "Bill";
            Employee23.Birthday = new DateTime(1999, 11, 14);
            Employee23.Address = "1212 N. First Ave";
            Employee23.City = "Round Rock";
            Employee23.State = "TX";
            Employee23.ZipCode = 78665;
            Employee23.SSN = 5554443333;
            Employee23.PhoneNumber = "9795554444";
            Employee23.UserName = "b.larson@longhorncinema.com";
            Employee23.Email = "b.larson@longhorncinema.com";
            var resultEmployee23 = UserManager.Create(Employee23, "approval");
            db.SaveChanges();
            Employee23 = db.Users.FirstOrDefault(u => u.Email == "b.larson@longhorncinema.com");
            if (UserManager.IsInRole(Employee23.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee23.Id, "Employee");
            }

            AppUser Employee24 = db.Users.FirstOrDefault(u => u.Email == "s.rankin@longhorncinema.com");
            Employee24 = new AppUser();
            Employee24.LastName = "Rankin";
            Employee24.MiddleInitial = "R";
            Employee24.FirstName = "Suzie";
            Employee24.Birthday = new DateTime(1999, 12, 17);
            Employee24.Address = "23 Polar Bear Road";
            Employee24.City = "Austin";
            Employee24.State = "TX";
            Employee24.ZipCode = 78712;
            Employee24.SSN = 1911919111;
            Employee24.PhoneNumber = "9893336666";
            Employee24.UserName = "s.rankin@longhorncinema.com";
            Employee24.Email = "s.rankin@longhorncinema.com";
            var resultEmployee24 = UserManager.Create(Employee24, "decorate");
            db.SaveChanges();
            Employee24 = db.Users.FirstOrDefault(u => u.Email == "s.rankin@longhorncinema.com");
            if (UserManager.IsInRole(Employee24.Id, "Employee") == false)
            {
                UserManager.AddToRole(Employee24.Id, "Employee");
            }

            db.SaveChanges();
        }
    }
}
