using CapstoneProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CapstoneProject.Controllers
{
    public class FriendsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ActionResult FriendsHome()
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
        public ActionResult SearchForFriends()
        {
            
            return View();
        }
        
        public ActionResult FriendAdded(FriendSearchModel search)
        {
            string currentUserId = User.Identity.GetUserId();
            string friend = search.addedFriend;

            var friendId = from f in db.Users
                           where f.Email == search.addedFriend
                           select f.Id;

            
            Friends friends = new Friends();
            friends.id = 0;
            friends.AdderName = currentUserId;
            friends.FriendName = friendId.FirstOrDefault();          
            db.Friends.Add(friends);
            db.SaveChanges();

            return View();
        }

        public ActionResult ViewAllUsers()
        {
            var allUsers = db.Users.ToList();
            return View(allUsers);
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
