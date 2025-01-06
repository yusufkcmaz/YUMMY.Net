using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        YummyContext context = new YummyContext();

        public ActionResult Index()
        {
            var value = context.ContactInfos.ToList();
            return View(value);
        }

        public ActionResult DeleteContact(int id)
        {
            var value = context.ContactInfos.Find(id);
            context.ContactInfos.Remove(value);
            context.SaveChanges();  
            return RedirectToAction("Index");
        }

        public ActionResult UpdateContact(int id)
        {
            var value = context.ContactInfos.Find(id );
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateContact (ContactInfo contactInfo)
        {
            var value =context.ContactInfos.Find(contactInfo.ContactInfoID);
            value.ADDRESS = contactInfo.ADDRESS;
            value.Email = contactInfo.Email;
            value.PhoneNumber = contactInfo.PhoneNumber;
            value.MapUrld = contactInfo.MapUrld;
            value.OpenHours = contactInfo.OpenHours;

            context.SaveChanges();
            return RedirectToAction("Index");   
        }

       
    }
}