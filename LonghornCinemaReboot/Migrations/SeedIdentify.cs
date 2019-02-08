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
    public class SeedIdentity
    {
        public void AddAdmin(AppDbContext db)
        {
            //create a user manager and a role manager to use for this method
            AppUserManager UserManager = new AppUserManager(new UserStore<AppUser>(db));

            //create a role manager
            AppRoleManager RoleManager = new AppRoleManager(new RoleStore<AppRole>(db));


            //check to see if the manager has been added
            AppUser manager = db.Users.FirstOrDefault(u => u.Email == "admin@example.com");

            //if manager hasn't been created, then add them
            if (manager == null)
            {
                //TODO: Add any additional fields for user here
                manager = new AppUser();
                manager.UserName = "admin@example.com";
                manager.FirstName = "Admin";
                manager.PhoneNumber = "(512)555-5555";
                manager.LastName = "Shmadmin";
                manager.Email = "admin@example.com";
                manager.Address = "408 Blessed Place";
                manager.Birthday = new DateTime(1949, 11, 23);

                var result = UserManager.Create(manager, "Abc123!");
                db.SaveChanges();
                manager = db.Users.First(u => u.UserName == "admin@example.com");
            }

            //TODO: Add the needed roles
            //if role doesn't exist, add it
            if (RoleManager.RoleExists("Manager") == false)
            {
                RoleManager.Create(new AppRole("Manager"));
            }

            if (RoleManager.RoleExists("Customer") == false)
            {
                RoleManager.Create(new AppRole("Customer"));
            }

            if (RoleManager.RoleExists("Employee") == false)
            {
                RoleManager.Create(new AppRole("Employee"));
            }

            if (RoleManager.RoleExists("Fired-Employee") == false)
            {
                RoleManager.Create(new AppRole("Fired-Employee"));
            }

            //make sure user is in role
            if (UserManager.IsInRole(manager.Id, "Manager") == false)
            {
                UserManager.AddToRole(manager.Id, "Manager");
            }

            //save changes
            db.SaveChanges();
        }

    }
}