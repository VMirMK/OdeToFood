using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using OdeToFood.Infrastructure;
using OdeToFood.Models;

namespace OdeToFood
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            //Ignore files with extension .axd
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Cuisine", // Route name
                "Cuisine/{name}", // URL with parameters
                new {controller = "Cuisine", action = "Search",name = UrlParameter.Optional} // Parameter defaults
                );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new {controller = "Home", action = "Index", id = UrlParameter.Optional} // Parameter defaults
                );

        }

        protected void Application_Start()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OdeToFoodDB>()); Creates new database if there are changes
            //Database.SetInitializer(new OdeToFoodDBInitializer()); 
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }

    public class OdeToFoodDBInitializer : DropCreateDatabaseIfModelChanges<OdeToFoodDB>
    {
        protected override void Seed(OdeToFoodDB context)
        {
            base.Seed(context);

            context.Restaurants.Add(new Restaurant
            {
                Name = "Restoran",
                Adress = new Adress
                {
                    City = "Washington",
                    State = "DC",
                    Country = "USA"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "Gurmet",
                Adress = new Adress
                {
                    City = "Centar",
                    State = "Skopje",
                    Country = "Macedonia"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "Krchma",
                Adress = new Adress
                {
                    City = "Martolci",
                    State = "Veles",
                    Country = "Macedonia"
                }
            });

            context.SaveChanges();
        }
    }
}