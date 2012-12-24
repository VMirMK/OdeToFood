using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Search(string name="Macedonian")
        {
            name = Server.HtmlEncode(name);
            return Content(name);
        }

    }
}
