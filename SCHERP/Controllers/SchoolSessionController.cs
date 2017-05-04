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

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public JsonResult CreateSession(SchoolSession session)
        {
            if (session != null)
            {
                return Json(new { msg = "1", reason = "Full!" });

            }
            return Json(new { msg = "0", reason = "Empty!" });
        }
    }
}