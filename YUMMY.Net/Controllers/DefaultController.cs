using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;

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
    }
}