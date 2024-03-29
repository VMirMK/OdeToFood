﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        OdeToFoodDB _db = new OdeToFoodDB();
        //
        // GET: /Reviews/

        public ActionResult Index()
        {
            var model = _db.Reviews;
            return View(model);
        }

        [ChildActionOnly] //so it canot be accessed through /Reviews/BestReview
        public ActionResult BestReview()
        {
            var model = _db.Reviews.FindTheBest();
            return PartialView("_Review", model);
        }

        //
        // GET: /Reviews/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create

        public ActionResult Create()
        {
            return View(new Review());
        } 

        //
        // POST: /Reviews/Create

        [HttpPost]
        public ActionResult Create(int restaurantID, Review newReview)
        {
            try
            {
                // TODO: Add insert logic here
                var restaurant = _db.Restaurants.Single(r => r.ID == restaurantID);
                restaurant.Reviews.Add(newReview); 
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Reviews/Edit/5
 
        public ActionResult Edit(int id)
        {
            var review = _db.Reviews.First(r => r.ID == id);
            return View(review);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _db.Reviews.First(r => r.ID == id);
            if (TryUpdateModel(review))
            {
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        //
        // GET: /Reviews/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
