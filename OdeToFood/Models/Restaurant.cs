using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        //virtual for enabling Lazy Loading and more efficient change tracking mechanism
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ChefsName { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        //public string StreetAdress { get; set; }
        //public string City { get; set; }
        //public string State { get; set; }
        //public string Country { get; set; }
        //public string ImageUrl { get; set; }
    }
}