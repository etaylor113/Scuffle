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
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("RegisterAccessRequired", "ErrorMessages");
            }      
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
            var person = db.Users.Where(item => item.UserName == User.Identity.Name).First();
            person.MondayPlan = model.MondayPlan;
            person.TuesdayPlan = model.TuesdayPlan;
            person.WednesdayPlan = model.WednesdayPlan;
            person.ThursdayPlan = model.ThursdayPlan;
            person.FridayPlan = model.FridayPlan;
            person.SaturdayPlan = model.SaturdayPlan;
            person.SundayPlan = model.SundayPlan;
     
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ChartCreated", "WorkoutPlan", db.Users.ToList());
        }

        public ActionResult ChartCreated()
        {
            return View();
        }
        public ActionResult ViewWorkoutChart()
        {
            return View(db.Users.ToList());
        }         
    }      
}