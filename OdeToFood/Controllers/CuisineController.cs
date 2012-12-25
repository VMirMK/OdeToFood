using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Infrastructure;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Parameter with default value</param>
        /// <returns></returns>
        [HttpGet]
        //[Authorize]
            //[Log]
        public ActionResult Search(string name="*")
        {
            throw new Exception("kablaaaam!");
            //if (name == "*")
            //{
            //    //return Json(new {Cuisinename = name}, JsonRequestBehavior.AllowGet);
            //    //return File(Server.MapPath("~/Content/Site.css"), "Site.css");
            //    return RedirectToRoute("Cuisine", new { name = "Macedonian" });
            //    //return RedirectToActionPermanent("Search", "Cuisine", new { name = "french" });
            //    //return RedirectToAction("Search", "Cuisine", new {name = "french"});
            //}

            name = Server.HtmlEncode(name);
            return Content(name);
            //return RedirectToAction("Index", "Home");
        }

    }
}
