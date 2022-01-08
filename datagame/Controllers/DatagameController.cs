using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace datagame.Controllers
{
    public class DatagameController : Controller
    {
        // GET: Datagame
        public ActionResult Index()
        {
            return View();
        }

        // GET: Datagame/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Datagame/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Datagame/Create
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

        // GET: Datagame/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Datagame/Edit/5
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

        // GET: Datagame/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Datagame/Delete/5
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
