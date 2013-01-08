using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/

        OdeToFoodDB _db = new OdeToFoodDB();

        public ActionResult Index(string country)
        {
            ViewBag.Countries = _db.Restaurants.Select(r => r.Adress.Country).Distinct();
            var model = from r in _db.Restaurants
                        orderby r.Name
                        where r.Adress.Country.Contains(country) || country ==null
                        select r;
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _db.Restaurants.Single(r => r.ID == id);
            return View(model);
        }
    }
}
