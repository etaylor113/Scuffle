using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class EventsController : Controller
    {
        // GET: Event
        public ActionResult ViewEvents()
        {
            return View();
        }
    }
}