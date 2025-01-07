using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class ChefsController : Controller
    {
        // GET: Chefs
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var values = context.Chefs.ToList();
            return View(values);
        }


        public ActionResult AddChef()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddChef(Chef Yenıyıl)
        {
            var values = context.Chefs.Add(Yenıyıl);
            context.SaveChanges();

            return RedirectToAction("Index");   
        }

       
        public ActionResult DeleteChef(int id )
        {
            var value = context.Chefs.Find(id); 
            context.Chefs.Remove(value); 
            context .SaveChanges(); 

            return RedirectToAction("Index");
        }


        public ActionResult UpdateChef(int id )
        {
            var value = context.Chefs.FirstOrDefault(x=> x.ChefId ==id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateChef(Chef Yenıyıl)
        {

            var value = context.Chefs.FirstOrDefault(x=> x.ChefId==Yenıyıl.ChefId);

            value.ImageUrl = Yenıyıl.ImageUrl;
            value.Name = Yenıyıl.Name;
            value.Title = Yenıyıl.Title;
            value.Description = Yenıyıl.Description;            

             context.SaveChanges();
            return RedirectToAction("Index");

        }

    }


}