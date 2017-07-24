﻿using CapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class WorkoutPlanController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult WorkoutPlanHome()
        {
            return View();
        }

        public ActionResult CreateWorkoutChart()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateWorkoutChart(RegisterViewModel model)
        {
            var user = db.Users.Where(item => item.UserName == User.Identity.Name).First();
            user.MondayPlan = model.MondayPlan;
            user.TuesdayPlan = model.TuesdayPlan;
            user.WednesdayPlan = model.WednesdayPlan;
            user.ThursdayPlan = model.ThursdayPlan;
            user.FridayPlan = model.FridayPlan;
            user.SaturdayPlan = model.SaturdayPlan;
            user.SundayPlan = model.SundayPlan;
            db.SaveChanges();
            return RedirectToAction("ChartCreated");
        }

        public ActionResult ChartCreated()
        {
            return View();
        }
        public ActionResult ViewWorkoutChart()
        {
            return View();
        }         
    }      
}