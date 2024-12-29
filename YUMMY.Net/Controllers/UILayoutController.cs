using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;

namespace YUMMY.Net.Controllers
{
    [AllowAnonymous]
    public class UILayoutController : Controller
    {
        YummyContext context = new YummyContext();    
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult SocialMedias()
        {
            var values =context.SocialMedias.ToList ();
            return PartialView(values);
        }
    }
}