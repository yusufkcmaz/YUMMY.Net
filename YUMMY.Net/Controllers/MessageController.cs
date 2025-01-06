using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;

namespace YUMMY.Net.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message

        YummyContext context = new YummyContext();

        public ActionResult Index()
        {
            var value = context.messages.ToList();
            return View(value);
        }


        public ActionResult DeleteMessage(int id)
        {
            var value = context.messages.Find(id);
            context.messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult IsRead(int id)
        {
            var message = context.messages.Find(id); // Mesajı ID ile bul
                    
            message.IsRead = true; // Mesajı okundu olarak işaretle
            context.SaveChanges(); 

            return RedirectToAction("Index"); 
        }

        public ActionResult Details(int id)
        {
            var value = context.messages.FirstOrDefault(x=> x.MessageID == id); 
            return View(value); 
                
                 
        }






    }
}