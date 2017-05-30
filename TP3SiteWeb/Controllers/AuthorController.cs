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
    public class AuthorController : Controller
    {
        private IdotTP2Entities db = new IdotTP2Entities();

        // GET: Author
        public ActionResult Index()
        {
            return View(db.T_Author.ToList());
        }

        // GET: Author/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Author t_Author = db.T_Author.Find(id);
            if (t_Author == null)
            {
                return HttpNotFound();
            }
            return View(t_Author);
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Firstname")] T_Author t_Author)
        {
            if (ModelState.IsValid)
            {
                db.T_Author.Add(t_Author);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(t_Author);
        }

        // GET: Author/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Author t_Author = db.T_Author.Find(id);
            if (t_Author == null)
            {
                return HttpNotFound();
            }
            return View(t_Author);
        }

        // POST: Author/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Firstname")] T_Author t_Author)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_Author).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t_Author);
        }

        // GET: Author/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            T_Author t_Author = db.T_Author.Find(id);
            if (t_Author == null)
            {
                return HttpNotFound();
            }
            return View(t_Author);
        }

        // POST: Author/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            T_Author t_Author = db.T_Author.Find(id);
            db.T_Author.Remove(t_Author);
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
