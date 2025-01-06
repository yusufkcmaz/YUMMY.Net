using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;

namespace YUMMY.Net.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            ViewBag.soupCount = context.products.Count(x => x.Category.CategoryName == "Ana Yemekler");
           
            ViewBag.MostExpensive = context.products.OrderByDescending(x=>x.Price).Select(x=>x.ProductName).FirstOrDefault();

            ViewBag.AvgPrice = context.products.Average(x => x.Price);

            //ViewBag.MinPrice = context.products.Min(x => x.Price);
            ViewBag.cheapestPrice = context.products.OrderBy(x => x.Price).Select(x => x.ProductName).FirstOrDefault();

            var value = context.products.OrderByDescending(Z => Z.ProductId).ToList();

            return View(value);
        }
    }
}