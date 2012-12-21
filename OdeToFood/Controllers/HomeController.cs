using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message1 = "Welcome to ASP.NET MVC!";

            var model = new RestaurantReview
                            {
                                Name = "Gurmet",
                                Rating = 10
                            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Location = "Macedonia";
            return View();
        }
    }
}
