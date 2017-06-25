using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
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

        //[AcceptVerbs(HttpVerbs.Post)]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Exclude = "Id")] FormCollection session)
        //{
        //    if (ModelState.IsValid)
        //    {


        //    }

        //    return View("Index");
        //}
        [Authorize(Roles = "Super Admin, Admin")]
        public JsonResult CreateSchoolSession(SchoolSession session)
        {
            //if (!User.IsInRole("Admin") || !User.IsInRole("Super Admin"))
            //{
            //    return Json(new { msg = "0", Reason = "Entry Failed, Un-Athourized request!" });
            //}
            if (session.SessionL == null)
            {
                return Json(new { msg = "0", Reason = "Entry Failed, Session field is required!" });
            }
            if (session.YearL == null)
            {
                return Json(new { msg = "0", Reason = "Entry Failed, Year field is required!" });
            }
            if (session.Term == null)
            {
                return Json(new { msg = "0", Reason = "Entry Failed, Term field is required!" });
            }
            if (session.SchoolStart == null)
            {
                return Json(new { msg = "0", Reason = "Entry Failed, School Start field is required!" });
            }
            if (session.SchoolEnd == null)
            {
                return Json(new { msg = "0", Reason = "Entry Failed, School End field is required!" });
            }

            _sessionRepo = new SchoolSessionRepository();
            int _i = _sessionRepo.Insert(session);
            if (_i > 0)
            {
                return Json(new { msg = "1", Reason = "Entry Successfull!" });
            }
            return Json(new { msg = "0", Reason = "Entry Failed!" });
        }


        [Authorize(Roles = "Super Admin, Admin")]
        public JsonResult UpdateSchoolSession(SchoolSession session)
        {
            if (session.SessionL == null)
            {
                return Json(new { msg = "0", Reason = "Update Failed, Session field is required!" });
            }
            if (session.YearL == null)
            {
                return Json(new { msg = "0", Reason = "Update Failed, Year field is required!" });
            }
            if (session.Term == null)
            {
                return Json(new { msg = "0", Reason = "Update Failed, Term field is required!" });
            }
            if (session.SchoolStart == null)
            {
                return Json(new { msg = "0", Reason = "Update Failed, School Start field is required!" });
            }
            if (session.SchoolEnd == null)
            {
                return Json(new { msg = "0", Reason = "Update Failed, School End field is required!" });
            }

            _sessionRepo = new SchoolSessionRepository();
            int _i = _sessionRepo.Update(session);
            if (_i > 0)
            {
                return Json(new { msg = "1", Reason = "Update Successfull!" });
            }
            return Json(new { msg = "0", Reason = "Update Failed!" });
        }
        public ActionResult Edit(int? id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                _sessionRepo = new SchoolSessionRepository();
                var schSession = _sessionRepo.FindById(Convert.ToInt16(id));
                ViewBag.SchSession = schSession.ToList();
                return View();
            }
            return View("Index");
        }

        public ActionResult Delete(object id)
        {
            return View();
        }
    }
}