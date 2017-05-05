using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCHERP.Controllers
{
    [Authorize]
    public class ExamsAndRecordsController : Controller
    {
        // GET: ExamsAndRecords
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}