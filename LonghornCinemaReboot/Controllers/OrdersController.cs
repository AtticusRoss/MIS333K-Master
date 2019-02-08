using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LonghornCinemaReboot.DAL;
using LonghornCinemaReboot.Models;
using Microsoft.AspNet.Identity;

namespace LonghornCinemaReboot.Controllers
{
    public class OrdersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Orders
        [Authorize(Roles = "Employee, Customer, Manager")]
        public ActionResult Index()
        {
            return View(db.Orders.ToList());
        }



        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create(Int32? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Showing showing = db.Showings.Find(id);
            ViewBag.showingbagged = showing;
            if (showing == null)
            {
                return HttpNotFound();
            }
            List<Ticket> showtickets = db.Tickets.Where(o => o.Showing.ShowingID == id && o.Taken == false).ToList();


            MultiSelectList selSeats = new MultiSelectList(showtickets, "TicketID", "Seat");

            ViewBag.AvailableSeats = selSeats;

            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer, Employee")]
        public ActionResult Create([Bind(Include = "OrderID,OrderNumber,OrderDate,Notes")] Order order, int[] SelectedSeats)
        {
            //Find next registration number
            order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber();

            //Record date of registration
            order.OrderDate = DateTime.Today;

            //Add user to order
            AppUser user = db.Users.Find(User.Identity.GetUserId());
            order.AppUser = user;

            foreach (int i in SelectedSeats)
            {
                Ticket t = db.Tickets.Find(i);
                t.Order.OrderID = order.OrderID;
                order.Tickets.Add(t);
            }

            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                Messaging.EmailMessaging.SendEmail(order.AppUser.Email, "Congragulations on your order", "Your order has been placed");
                return RedirectToAction("AddToOrder", new { OrderID = order.OrderID });
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,OrderNumber,OrderDate,Notes")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromOrder(int OrderID)
        {
            Order ord = db.Orders.Find(OrderID);

            if (ord == null)//registration is not found
            {
                return RedirectToAction("Details", new { id = OrderID });
            }

            if (ord.Tickets.Count == 0) // there are no registration details
            {
                return RedirectToAction("Details", new { id = OrderID });
            }

            //pass the list of order details to the view
            return View(ord.Tickets);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
