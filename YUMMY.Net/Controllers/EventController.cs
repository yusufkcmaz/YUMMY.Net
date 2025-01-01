using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values =context.events.ToList();    
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEvent()
        {
            return View();
        }


        [HttpPost]  

        public ActionResult AddEvent(Event Evt)
        {
            context.events.Add(Evt);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
     

        public ActionResult DeleteEvent(int id)
        {
            var value = context.events.Find(id);  
            context.events.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");  
                     
        }

        public ActionResult EditEvent(int id)
        {
            var value = context.events.Find(id);
            return View(value); 

        }


        [HttpPost]

        public ActionResult EditEvent(Event editEvent)
        {
            var value = context.events.Find(editEvent.EventId);

            value.ImageUrl = editEvent.ImageUrl;
            value.Title = editEvent.Title;
            value.Description = editEvent.Description;
            value.Price = editEvent.Price;


            context.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}