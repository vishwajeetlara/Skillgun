using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EyeDoctor.Controllers
{
    public class SurvayController : Controller
    {
        // GET: Survay
        public ActionResult Index()
        {
            return View();
        }
      

        // GET: Survay/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Survay/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Survay/Create
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

        // GET: Survay/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Survay/Edit/5
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

        // GET: Survay/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Survay/Delete/5
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
