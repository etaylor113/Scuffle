using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class ChallengesController : Controller
    {
  
        public ActionResult ChallengesHome()
        {
            return View();
        }

        public ActionResult CreateChallenge()
        {
            return View();
        }

        public ActionResult ViewChallange()
        {
            return View();
        }

        public ActionResult ChallengeCrated()
        {
            return View();
        }
    }
}