using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DAL;

namespace SCHERP.Controllers
{
    [Authorize]
    public class SchoolSessionController : Controller
    {
        private SchoolSessionRepository _sessionRepo;
        // GET: SchoolSession
        [HttpGet]
        public ActionResult Index()
        {
            _sessionRepo = new SchoolSessionRepository();
            ViewBag.AllSession = _sessionRepo.ListSessions();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(SchoolSession session)
        {

            return View();
        }
    }
}