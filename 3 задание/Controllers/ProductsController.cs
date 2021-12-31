using _3_задание.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_задание.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult List()
        {
            return View(Product.list);
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return View(new Product());
            }
            Product product = Product.list.Find(item => item.Id == int.Parse(id));
            return View(product);
        }
    }
}