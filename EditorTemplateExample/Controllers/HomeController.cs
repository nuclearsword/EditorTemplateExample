using EditorTemplateExample.Models;
using EditorTemplateExample.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditorTemplateExample.Controllers
{
    public class HomeController : Controller
    {
        readonly FakeRepo repo;

        public HomeController()
        {
            repo = new FakeRepo();
        }
        //GET:INDEX
        public ActionResult Index()
        {
            return View();
        }

        //The examples
        [HttpGet]
        public ActionResult WithEditorTemplates()
        {
            SessionDetail details = new SessionDetail { sessions = repo.GetSessions() };
            return View(details);
        }
        [HttpGet]
        public ActionResult WithoutEditorTemplates()
        {
            SessionDetail details = new SessionDetail { sessions = repo.GetSessions() };
            return View(details);
        }
        [HttpPost]
        public ActionResult ThePostAction(SessionDetail details)
        {
            if (details.sessions is null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            List<Session> chosenSessions = details != null ? details.sessions.Where(m => m.IsSignedUp).ToList() : new List<Session>();
            return Receipt(chosenSessions);
        }

        //The results
        [HttpGet]
        public ActionResult Receipt(IEnumerable<Session> chosenSessions)
        {
            return View("Receipt",chosenSessions);
        }
    }
}