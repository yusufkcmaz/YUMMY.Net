using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        YummyContext context = new YummyContext();  
        public ActionResult Index()
        {
            var values = context.testimonials.ToList();
            return View(values);
        }

        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddTestimonial(Testimonial Tes)
        {
            if (!ModelState.IsValid)
            {
                return View(Tes);
            }
            context.testimonials.Add(Tes);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ViewBag.error = "Değerler kaydedilirken bir hata ile karşılaştı";
                return View(Tes);
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.testimonials.Find(id);
            context.testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}