using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SCHERP.Models;

namespace SCHERP.Controllers
{
    [Authorize(Roles = "Super Admin, Admin")]
    public class UserController : Controller
    {
        private UsersRepository _userRepo;
        private RoleUsersRepository _roleUser;

        ApplicationDbContext context = new ApplicationDbContext();


        // GET: User
        public ActionResult Index()
        {
            _userRepo = new UsersRepository();
            ViewBag.AllUSers = _userRepo.GetUsers();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return RedirectToAction("Error404", "Error");
            }

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var u = userManager.FindById(id);

            return View(u);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection user)
        {
            return View();
        }
    }
}