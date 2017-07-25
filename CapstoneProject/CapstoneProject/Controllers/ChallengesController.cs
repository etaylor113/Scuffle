using CapstoneProject.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class ChallengesController : Controller
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

        public ActionResult ChallengesHome()
        {
            return View();
        }

        public ActionResult CreateChallenge()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateChallenge(RegisterViewModel model)
        {
            var person = db.Users.Where(item => item.UserName == User.Identity.Name).First();
            person.ChallengeId = model.ChallengeId;
            person.ChallengeName = model.ChallengeName;
            person.StartDate = model.StartDate;
            person.EndDate = model.EndDate;
            person.GoalOne = model.GoalOne;
            person.GoalTwo = model.GoalTwo;
            person.GoalThree = model.GoalThree;
            person.GoalFour = model.GoalFour;
            person.GoalFive = model.GoalFive;
            person.DescOne = model.DescOne;
            person.DescTwo = model.DescTwo;
            person.DescThree = model.DescThree;
            person.DescFour = model.DescFour;
            person.DescFive = model.DescFive;
            person.DiffOne = model.DiffOne;
            person.DiffTwo = model.DiffTwo;
            person.DiffThree = model.DiffThree;
            person.DiffFour = model.DiffFour;
            person.DiffFive = model.DiffFive;

            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ChallengeCreated", "Challenges", db.Users.ToList());
        }

        public ActionResult ViewChallenge()
        {
            return View();
        }

        public ActionResult ChallengeCreated()
        {
            return View();
        }
    }
}