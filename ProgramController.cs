using Prac7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prac7.Controllers
{
    public class ProgramController : Controller
    {
            private static List<Program> feedbackList = new List<Program>();

            public ActionResult Index()
            {
                return View();
            }
            public ActionResult GiveFd()
            {
                return View();
            }
            [HttpPost]
            public ActionResult GiveFd(Program feedback)
            {
                if (ModelState.IsValid)
                {
                    feedbackList.Add(feedback);
                    return RedirectToAction("ViewFd");
                }

                return View(feedback);
            }
            public ActionResult ViewFd()
            {
                return View(feedbackList);
            }
    }
}