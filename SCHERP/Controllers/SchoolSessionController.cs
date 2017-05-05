using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DAL;
using SCHERP.Models;

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

        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Exclude = "Id")] FormCollection session)
        {
            if (ModelState.IsValid)
            {


            }

            return View("Index");
        }
    }
}