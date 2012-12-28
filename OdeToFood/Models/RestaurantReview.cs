using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public int Rating { get; set; }
        public DateTime Created { get; set; }

        public RestaurantReview FindTheBest()
        {
            return this;
        }
    }
}