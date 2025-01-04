using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default anasayfa
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DefaultFeature() /*PARTİALVİEW*/
        {
            var values = context.features.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultProduct()
        {
            var values = context.categories.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultService()
        {
            var values = context.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultTestimonials()
        {
            var values = context.testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultEvent()
        {
            var values = context.events.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultChefs()
        {
            var values = context.Chefs.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultBooking()
        {
            return PartialView();
        }


        [HttpPost]
        public string DefaultAddBooking(Booking booking)
        {
            context.bookings.Add(booking);
            context.SaveChanges();
            return "Rezervasyonunuz oluşturldu";
        }


        public PartialViewResult DefaultGallery()
        {
            var values = context.photoGalleries.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultContact()
        {
            var values = context.ContactInfos.ToList();
            return PartialView(values);
        }



        public PartialViewResult DefaultMessage()
        {
            return PartialView();
        }


        [HttpPost]
        public string DefaultSendMessage(Message mesajj)
        {
            context.messages.Add(mesajj);
          
            context.SaveChanges();
            return "Mesajınız Gönderildi.";

        }

               
    }
}