﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_ASP.NET_MVC.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home2/Create
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

        // GET: Home2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home2/Edit/5
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

        // GET: Home2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home2/Delete/5
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
