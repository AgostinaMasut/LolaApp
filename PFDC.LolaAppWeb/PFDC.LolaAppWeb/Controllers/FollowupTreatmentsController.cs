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
    public class FollowupTreatmentsController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: FollowupTreatments
        public ActionResult Index(int id)
        {
            Patient paciente = new Patient();
            ViewBag.UserName = paciente.Name;
            ViewBag.LastName = paciente.LastName;
            var tratamiento = (from c in db.FollowupTreatments orderby c.TreatmentId descending select c.TreatmentId).First();
            var followupTreatments = db.FollowupTreatments.Include(f => f.Patient).Include(f => f.Treatment).Include(f => f.User);
            return View(followupTreatments.ToList().Where(p => p.PatientId == id && p.TreatmentId == tratamiento));
        }

        // GET: FollowupTreatments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FollowupTreatment followupTreatment = db.FollowupTreatments.Find(id);
            if (followupTreatment == null)
            {
                return HttpNotFound();
            }
            return View(followupTreatment);
        }

        // GET: FollowupTreatments/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name");
            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description");
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: FollowupTreatments/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TreatmentId,SessionNumber,PatientId,UserId,Commentary")] FollowupTreatment followupTreatment)
        {
            if (ModelState.IsValid)
            {
                db.FollowupTreatments.Add(followupTreatment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name", followupTreatment.PatientId);
            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description", followupTreatment.TreatmentId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", followupTreatment.UserId);
            return View(followupTreatment);
        }

        // GET: FollowupTreatments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FollowupTreatment followupTreatment = db.FollowupTreatments.Find(id);
            if (followupTreatment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name", followupTreatment.PatientId);
            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description", followupTreatment.TreatmentId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", followupTreatment.UserId);
            return View(followupTreatment);
        }

        // POST: FollowupTreatments/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TreatmentId,SessionNumber,PatientId,UserId,Commentary")] FollowupTreatment followupTreatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(followupTreatment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name", followupTreatment.PatientId);
            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description", followupTreatment.TreatmentId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", followupTreatment.UserId);
            return View(followupTreatment);
        }

        // GET: FollowupTreatments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FollowupTreatment followupTreatment = db.FollowupTreatments.Find(id);
            if (followupTreatment == null)
            {
                return HttpNotFound();
            }
            return View(followupTreatment);
        }

        // POST: FollowupTreatments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FollowupTreatment followupTreatment = db.FollowupTreatments.Find(id);
            db.FollowupTreatments.Remove(followupTreatment);
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
