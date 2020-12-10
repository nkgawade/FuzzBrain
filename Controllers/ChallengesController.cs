using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuzzBrain.Controllers
{
    public class ChallengesController : Controller
    {
        // GET: Challenges
        public ActionResult Index()
        {
            return View();
        }
    }
}