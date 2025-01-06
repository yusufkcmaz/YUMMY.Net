using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YUMMY.Net.Context;
using YUMMY.Net.Models;

namespace YUMMY.Net.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        YummyContext context = new YummyContext();
        public ActionResult Index()
        {
            var products = context.products.ToList();
            return View(products);
        }


        public ActionResult DeleteProduct(int id)
        {
            var product = context.products.Find(id);
            context.products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> category = (from x in context.categories
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.kategoriler = category;

            var product = context.products.Find(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product model)
        {
            var product = context.products.Find(model.ProductId);
            product.ProductName = model.ProductName;
            product.ImageUrl = model.ImageUrl;
            product.Price = model.Price;
            product.CategoryId = model.CategoryId;
            product.Ingredients = model.Ingredients;
            context.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> category = (from x in context.categories
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.kategoriler = category;

            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product model)
        {
            context.products.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }









    }





}