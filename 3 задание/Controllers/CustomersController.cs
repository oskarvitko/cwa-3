using _3_задание.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_задание.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            return View(Customer.list);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string name, string surname, string age, string phone)
        {
            int _age = -1;
            try { _age = int.Parse(age); } catch (Exception e) { return View(); }

            Customer.list.Add(new Customer(
                name,
                surname,
                _age,
                phone
                ));
            return Redirect("/Customers/Index");
        }
    }

}