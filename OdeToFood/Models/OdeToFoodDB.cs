using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OdeToFood.Models
{
    public class OdeToFoodDB : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<RestaurantReview> Reviews { get; set; }
        //static OdeToFood()
        //{
        //    _reviews = new List<RestaurantReview>();
        //    _reviews.Add(new RestaurantReview
        //    {
        //        Name = "Restoran",
        //        Rating = 6,
        //        Body = "aren",
        //        Created = DateTime.Now,
        //        ID = 1,
        //        ImageUrl = "../Content/images/grd_alt.png"
        //    });
        //    _reviews.Add(new RestaurantReview
        //                     {
        //                         Name = "Gurmet",
        //                         Rating = 10,
        //                         Body = "super",
        //                         Created = DateTime.Now,
        //                         ID = 2,
        //                         ImageUrl = "../Content/images/button-cancel.png"
        //                     });
        //    _reviews.Add(new RestaurantReview
        //                     {
        //                         Name = "Krchma",
        //                         Rating = 1,
        //                         Body = "strava",
        //                         //Body = "<script type='text/javascript'>alert('xss!')</script>",
        //                         Created = DateTime.Now,
        //                         ID = 3,
        //                         ImageUrl = "../Content/images/Tulliana Icon 43.png"
        //                     });
        //}

        //private static List<RestaurantReview> _reviews;

        //public List<RestaurantReview> Reviews
        //{
        //    get { return _reviews; }
        //    set { _reviews = value; }
        //}

        //public static RestaurantReview FindTheBest(this List<RestaurantReview> db)
        //{
        //    return _reviews.First();
        //}
    }
}