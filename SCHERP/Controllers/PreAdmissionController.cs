﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCHERP.Controllers
{
    [Authorize]
    public class PreAdmissionController : Controller
    {
        // GET: PreAdmission
        public ActionResult Index()
        {
            return View();
        }

        // GET: PreAdmission/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PreAdmission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PreAdmission/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PreAdmission/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PreAdmission/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PreAdmission/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PreAdmission/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}