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
    public class ProfessionalTimelinesController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: ProfessionalTimelines
        public ActionResult Index()
        {
            var professionalTimeline = db.ProfessionalTimeline.Include(p => p.Branch).Include(p => p.User);
            return View(professionalTimeline.ToList());
        }

        // GET: ProfessionalTimelines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessionalTimeline professionalTimeline = db.ProfessionalTimeline.Find(id);
            if (professionalTimeline == null)
            {
                return HttpNotFound();
            }
            return View(professionalTimeline);
        }

        // GET: ProfessionalTimelines/Create
        public ActionResult Create()
        {
            ViewBag.BranchId = new SelectList(db.Branch, "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: ProfessionalTimelines/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Day,Input,Output,UserId,BranchId")] ProfessionalTimeline professionalTimeline)
        {
            if (ModelState.IsValid)
            {
                db.ProfessionalTimeline.Add(professionalTimeline);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BranchId = new SelectList(db.Branch, "Id", "Name", professionalTimeline.BranchId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", professionalTimeline.UserId);
            return View(professionalTimeline);
        }

        // GET: ProfessionalTimelines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessionalTimeline professionalTimeline = db.ProfessionalTimeline.Find(id);
            if (professionalTimeline == null)
            {
                return HttpNotFound();
            }
            ViewBag.BranchId = new SelectList(db.Branch, "Id", "Name", professionalTimeline.BranchId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", professionalTimeline.UserId);
            return View(professionalTimeline);
        }

        // POST: ProfessionalTimelines/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Day,Input,Output,UserId,BranchId")] ProfessionalTimeline professionalTimeline)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professionalTimeline).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BranchId = new SelectList(db.Branch, "Id", "Name", professionalTimeline.BranchId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", professionalTimeline.UserId);
            return View(professionalTimeline);
        }

        // GET: ProfessionalTimelines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessionalTimeline professionalTimeline = db.ProfessionalTimeline.Find(id);
            if (professionalTimeline == null)
            {
                return HttpNotFound();
            }
            return View(professionalTimeline);
        }

        // POST: ProfessionalTimelines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfessionalTimeline professionalTimeline = db.ProfessionalTimeline.Find(id);
            db.ProfessionalTimeline.Remove(professionalTimeline);
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
