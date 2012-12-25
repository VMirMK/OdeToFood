using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class FoodDb
    {
        static FoodDb()
        {
            _reviews = new List<RestaurantReview>();
            _reviews.Add(new RestaurantReview { Name = "Restoran", Rating = 6 });
            _reviews.Add(new RestaurantReview { Name = "Gurmet", Rating = 10 });
            _reviews.Add(new RestaurantReview { Name = "Krchma", Rating = 1 });
        }

        private static List<RestaurantReview> _reviews;

        public List<RestaurantReview> Reviews
        {
            get { return _reviews; }
            set { _reviews = value; }
        }

    }
}