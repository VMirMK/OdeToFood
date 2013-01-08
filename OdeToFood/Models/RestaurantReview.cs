using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Review
    {
        public virtual int ID { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        [Required]
        public virtual string Body { get; set; }
        [Range(1,10)]
        public virtual int Rating { get; set; }
        public virtual DateTime Created { get; set; }

        //public RestaurantReview FindTheBest()
        //{
        //    return this;
        //}
    }
}