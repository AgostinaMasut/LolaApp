using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PFDC.LolaAppWeb.Data;
using PFDC.LolaAppWeb.Models;

namespace PFDC.LolaAppWeb.Controllers
{
    public class StretchersController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: Stretchers
        public ActionResult Index()
        {
            return View(db.Stretcher.ToList());
        }

        // GET: Stretchers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stretcher stretcher = db.Stretcher.Find(id);
            if (stretcher == null)
            {
                return HttpNotFound();
            }
            return View(stretcher);
        }

        // GET: Stretchers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stretchers/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descrption")] Stretcher stretcher)
        {
            if (ModelState.IsValid)
            {
                db.Stretcher.Add(stretcher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stretcher);
        }

        // GET: Stretchers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stretcher stretcher = db.Stretcher.Find(id);
            if (stretcher == null)
            {
                return HttpNotFound();
            }
            return View(stretcher);
        }

        // POST: Stretchers/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descrption")] Stretcher stretcher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stretcher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stretcher);
        }

        // GET: Stretchers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stretcher stretcher = db.Stretcher.Find(id);
            if (stretcher == null)
            {
                return HttpNotFound();
            }
            return View(stretcher);
        }

        // POST: Stretchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stretcher stretcher = db.Stretcher.Find(id);
            db.Stretcher.Remove(stretcher);
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
