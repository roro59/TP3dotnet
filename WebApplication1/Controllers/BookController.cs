using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DataAccess;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        private IdotTP2Entities db = new IdotTP2Entities();

        // GET: Book
        public ActionResult Index()
        {
            var t_Book = db.T_Book.Include(t => t.T_Author);
            return View(t_Book.ToList());
        }

        // GET: Book/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Book t_Book = db.T_Book.Find(id);
            if (t_Book == null)
            {
                return HttpNotFound();
            }
            return View(t_Book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            ViewBag.IdAuthor = new SelectList(db.T_Author, "Id", "Name");
            return View();
        }

        // POST: Book/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Publication,IdAuthor")] T_Book t_Book)
        {
            if (ModelState.IsValid)
            {
                db.T_Book.Add(t_Book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdAuthor = new SelectList(db.T_Author, "Id", "Name", t_Book.IdAuthor);
            return View(t_Book);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Book t_Book = db.T_Book.Find(id);
            if (t_Book == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAuthor = new SelectList(db.T_Author, "Id", "Name", t_Book.IdAuthor);
            return View(t_Book);
        }

        // POST: Book/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Publication,IdAuthor")] T_Book t_Book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdAuthor = new SelectList(db.T_Author, "Id", "Name", t_Book.IdAuthor);
            return View(t_Book);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Book t_Book = db.T_Book.Find(id);
            if (t_Book == null)
            {
                return HttpNotFound();
            }
            return View(t_Book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            T_Book t_Book = db.T_Book.Find(id);
            db.T_Book.Remove(t_Book);
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
