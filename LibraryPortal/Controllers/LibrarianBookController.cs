using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryPortal.DAL;
using LibraryPortal.Models;

namespace LibraryPortal.Controllers
{
    public class LibrarianBookController : Controller
    {
        private LibraryManagementContext db = new LibraryManagementContext();
        private DataGateway<Book> bookDataGateway = new DataGateway<Book>();
        // GET: LibrarianBook
        public ActionResult Index()
        {
            return View(bookDataGateway.SelectAll());
        }

        // GET: LibrarianBook/Details/5
        public ActionResult Details(int id)
        {

            Book book = bookDataGateway.SelectById(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: LibrarianBook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibrarianBook/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "bookID,transactionID,bookTitle,author,loanStatus")] Book book)
        {
            if (ModelState.IsValid)
            {
                bookDataGateway.Insert(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        // GET: LibrarianBook/Edit/5
        public ActionResult Edit(int id)
        {

            Book book = bookDataGateway.SelectById(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: LibrarianBook/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                    Book book = bookDataGateway.SelectById(id);
                    bookDataGateway.Update(book, id);
                    db.SaveChanges();
                    return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(bookDataGateway.SelectById(id));
            }
          
            
        }

        // GET: LibrarianBook/Delete/5
        public ActionResult Delete(int id)
        {

            Book book = bookDataGateway.SelectById(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: LibrarianBook/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            bookDataGateway.Delete(id);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
