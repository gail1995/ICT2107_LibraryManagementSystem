using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryPortal.Controllers
{
    public class LibrarianBookController : Controller
    {
        // GET: LibrarianBook
        public ActionResult Index()
        {
            return View();
        }

        // GET: LibrarianBook/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LibrarianBook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibrarianBook/Create
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

        // GET: LibrarianBook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LibrarianBook/Edit/5
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

        // GET: LibrarianBook/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LibrarianBook/Delete/5
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
