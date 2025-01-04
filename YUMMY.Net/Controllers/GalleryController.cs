using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.photoGalleries.ToList();
            return View(values);
        }

        public ActionResult UpdateGallery(int id)
        {
            var value = context.photoGalleries.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateGallery(PhotoGallery gallery)
        {
            var value = context.photoGalleries.Find(gallery.PhotoGalleryId);

            value.PhotoGalleryId = gallery.PhotoGalleryId;
            value.ImageUrl = gallery.ImageUrl;

            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteGallery(int id)
        {
            var value = context.photoGalleries.Find(id);
            context.photoGalleries.Remove(value);   
            context.SaveChanges();  
            return RedirectToAction("Index");   
        }
    }
}