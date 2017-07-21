using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace CapstoneProject.Controllers
{
    public class ErrorMessagesController : Controller
    {
        public ActionResult RegisterAccessRequired()
        {
            return View();
        }

    }
}
