using FuzzBrain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuzzBrain.Controllers
{
    [Authorize(Roles = "Admin,User")]
    public class ChallengesController : Controller
    {
        // GET: Challenges
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetChallenge(int id)
        {
            List<QuestionModel> questionList = QuestionModel.GetReactQuestionList();
            ViewData["QuestionId"] = id;
            if (id == 1)
            {
                return View(questionList);
            }
            else if (id == 2)
            {
                return View();
            }

            return View(questionList);
        }
    }
}