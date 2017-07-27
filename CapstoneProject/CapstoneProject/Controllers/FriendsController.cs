using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class FriendsController : Controller
    {
        public ActionResult FriendsHome()
        {
            return View();
        }
        public ActionResult SearchForFriends()
        {
            return View();
        }

        public ActionResult ViewFriendList()
        {
            return View();
        }

        public ActionResult ViewFriendWorkout()
        {
            return View();
        }
    }
}
