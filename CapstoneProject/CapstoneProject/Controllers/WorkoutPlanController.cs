using CapstoneProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class WorkoutPlanController : Controller
    {

        ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                userManager = value;
            }
        }

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
     
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ChartCreated", "WorkoutPlan", db.Users.ToList());
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