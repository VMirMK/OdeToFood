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
        OdeToFoodDB _db = new OdeToFoodDB();
        public ActionResult Index()
        {
            ViewBag.Message = string.Format("{0} {1} {2} ", RouteData.Values["controller"], RouteData.Values["action"],
                                            RouteData.Values["id"]);

            //var model = new Review
            //                {
            //                    //Name = "Gurmet",
            //                    Rating = 10
            //                };
            var model = _db.Reviews.FirstOrDefault();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Location = "Macedonia";
            return View();
        }
    }
}
