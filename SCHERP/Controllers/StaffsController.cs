using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCHERP.Controllers
{
    [Authorize]
    public class StaffsController : Controller
    {
        // GET: Staffs
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