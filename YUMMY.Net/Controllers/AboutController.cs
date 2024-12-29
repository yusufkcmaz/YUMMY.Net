using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        YummyContext context = new YummyContext();
      
        [HttpGet]

        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }


     
        public ActionResult UpdateAbout()
        {
            var value = context.Abouts.FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About model)
        {
            
            if (ModelState.IsValid)
            {
                var value = context.Abouts.FirstOrDefault();

                if (value != null)
                {

                    value.ImageUrl = model.ImageUrl;
                    value.Item1 = model.Item1;
                    value.Item2 = model.Item2;
                    value.Item3 = model.Item3;
                    value.Description = model.Description;
                    value.VideoUrl = model.VideoUrl;
                    value.PhoneNumber = model.PhoneNumber;
                    value.ImageUrl2 = model.ImageUrl2;


                    context.SaveChanges();

                }
                else
                {

                    ModelState.AddModelError("", "Veri bulamadı.");
                }
                return RedirectToAction("Index" ,"About");

            }

            return View("Index"); 

        }
    }
}