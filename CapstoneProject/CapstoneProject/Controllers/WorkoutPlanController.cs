using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class WorkoutPlanController : Controller
    {
        // GET: WorkoutPlan
        public ActionResult WorkoutPlanHome()
        {
            return View();
        }
            public ActionResult CreateWorkoutChart()
        {
            return View();
        }
        public ActionResult ViewWorkoutChart()
        {
            return View();
        }         
    }      
}