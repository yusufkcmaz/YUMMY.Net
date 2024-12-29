using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var Ser = context.Services.ToList();
            return View(Ser);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var Vic = context.Services.FirstOrDefault(s => s.ServiceId == id);
            //var Vic = context.Services.();
            return View(Vic);   
        }


        [HttpPost]
        public ActionResult Update(Service upt)
        {
            var value = context.Services.FirstOrDefault(s=> s.ServiceId == upt.ServiceId);
            if (value == null)
            {
                TempData["Error"] = "Service not found!";
                return RedirectToAction("Index");
            }
             
            value.Title = upt.Title;   
            value.Description = upt.Description;
            context.SaveChanges();
            return RedirectToAction("Index");   
        }
    }   
}