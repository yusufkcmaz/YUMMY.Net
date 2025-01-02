using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class DefaultBookingController : Controller
    {
        // GET: DefaultBooking
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var book = context.bookings.ToList();
            return View(book);
        }


      
        public ActionResult ApproveBooking(int id)
        {
            var booking = context.bookings.Find(id);
            booking.ISapproved = true; 
            context.SaveChanges();
           
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteBooking(int id)
        {
            var booking = context.bookings.Find(id);
            if (booking != null)
            {
                context.bookings.Remove(booking);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult AddBooking()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddBooking(Booking Yenıyıl)
        {
            var values = context.bookings.Add(Yenıyıl);
            context.SaveChanges();

            return RedirectToAction("Index");
        }





    }
}   