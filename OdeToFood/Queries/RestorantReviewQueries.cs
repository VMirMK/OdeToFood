﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OdeToFood.Models;

namespace OdeToFood.Queries
{
    public static class RestorantReviewQueries
    {
        public static IEnumerable<Review> FindTheLatest(this IQueryable<Review> reviews,int numberOfReviews)
        {
            return reviews.OrderByDescending(r => r.Created).Take(numberOfReviews);
        }

        public static Review FindById(this IQueryable<Review> reviews, int id)
        {
            return reviews.Single(r=>r.ID==id);
        }

        public static Review FindTheBest(this IQueryable<Review> reviews)
        {
            return reviews.OrderByDescending(r => r.Rating).First();
        }
    }
}