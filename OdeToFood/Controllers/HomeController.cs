using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDB _db = new OdeToFoodDB();

        public PartialViewResult LatestReview()
        {
            Thread.Sleep(800);
            var review = _db.Reviews.FindTheLatest(1).Single();
            return PartialView("_Review", review);
        }

        public PartialViewResult Search(string q)
        {
            Thread.Sleep(200);
            var restaurants = _db.Restaurants.Where(r => String.IsNullOrEmpty(q) || r.Name.Contains(q)).Take(10);
            return PartialView("_RestaurantSearchResults", restaurants);
        }

        public ActionResult QuickSearch(string term)
        {
            //autocomplete will send term parameter in the request
            var restaurants = _db.Restaurants
                .Where(r => String.IsNullOrEmpty(term) || r.Name.Contains(term)).Take(10)
                .Select(r => new { label = r.Name });
            //working wit autocomplete requires Json objects that have label property
            return Json(restaurants, JsonRequestBehavior.AllowGet);
        }

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
