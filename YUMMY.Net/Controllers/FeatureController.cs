using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{


    public class FeatureController : Controller
    {
        // GET: Feature
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.features.ToList();
            return View(values);
        }

        public ActionResult AddFeature()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddFeature(Feature feature)
        {
            if (!ModelState.IsValid)
            {
                return View(feature);
            }
            context.features.Add(feature);
            int result = context.SaveChanges();
            if (result == 0)
            {
                ViewBag.error = "Değerler kaydedilirken bir hata ile karşılaştı";
                return View(feature);
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteFeature(int id)
        {
            var value = context.features.Find(id);
            context.features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult UpdateFeature()
        {
            var value = context.features.FirstOrDefault();
            return View(value);
        }



        [HttpPost]
        public ActionResult UpdateFeature(Feature model)
        {

            if (ModelState.IsValid)
            {
                var value = context.features.FirstOrDefault();

                if (value != null)
                {

                    value.ImageUrl = model.ImageUrl;
                    value.Title = model.Title;
                    value.Description = model.Description;
                    value.VideoUrl = model.VideoUrl;


                    context.SaveChanges();

                }
                else
                {

                    ModelState.AddModelError("", "Veri bulamadı.");
                }
                return RedirectToAction("Index", "Feature");

            }

            return View("Index");





        }







    }
}