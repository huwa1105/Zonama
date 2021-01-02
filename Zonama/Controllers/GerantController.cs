using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zonama.DAL;
using Zonama.Models;

namespace Zonama.Controllers
{
    public class GerantController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: Gerant
        public ActionResult Index()
        {
            return View(db.Gerant.ToList());
        }

        // GET: Gerant/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gerant gerant = db.Gerant.Find(id);
            if (gerant == null)
            {
                return HttpNotFound();
            }
            return View(gerant);
        }

        // GET: Gerant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gerant/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_ger,nom,prenom,tel,email,password")] Gerant gerant)
        {
            if (ModelState.IsValid)
            {
                db.Gerant.Add(gerant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gerant);
        }

        // GET: Gerant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gerant gerant = db.Gerant.Find(id);
            if (gerant == null)
            {
                return HttpNotFound();
            }
            return View(gerant);
        }

        // POST: Gerant/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_ger,nom,prenom,tel,email,password")] Gerant gerant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gerant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gerant);
        }

        // GET: Gerant/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gerant gerant = db.Gerant.Find(id);
            if (gerant == null)
            {
                return HttpNotFound();
            }
            return View(gerant);
        }

        // POST: Gerant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gerant gerant = db.Gerant.Find(id);
            db.Gerant.Remove(gerant);
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
