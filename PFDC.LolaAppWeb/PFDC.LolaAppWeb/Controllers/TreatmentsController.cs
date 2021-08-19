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
    public class TreatmentsController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: Treatments
        public ActionResult Index()
        {
            var treatment = db.Treatment.Include(t => t.Frequency).Include(t => t.Machine).Include(t => t.Stretcher);
            return View(treatment.ToList());
        }

        // GET: Treatments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // GET: Treatments/Create
        public ActionResult Create()
        {
            ViewBag.FrequencyId = new SelectList(db.Frequency, "Id", "Id");
            ViewBag.MachineId = new SelectList(db.Machine, "Id", "Description");
            ViewBag.StretcherId = new SelectList(db.Stretcher, "Id", "Descrption");
            return View();
        }

        // POST: Treatments/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,AmountSession,DurationSession,FrequencyId,MachineId,StretcherId")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Treatment.Add(treatment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FrequencyId = new SelectList(db.Frequency, "Id", "Id", treatment.FrequencyId);
            ViewBag.MachineId = new SelectList(db.Machine, "Id", "Description", treatment.MachineId);
            ViewBag.StretcherId = new SelectList(db.Stretcher, "Id", "Descrption", treatment.StretcherId);
            return View(treatment);
        }

        // GET: Treatments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            ViewBag.FrequencyId = new SelectList(db.Frequency, "Id", "Id", treatment.FrequencyId);
            ViewBag.MachineId = new SelectList(db.Machine, "Id", "Description", treatment.MachineId);
            ViewBag.StretcherId = new SelectList(db.Stretcher, "Id", "Descrption", treatment.StretcherId);
            return View(treatment);
        }

        // POST: Treatments/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,AmountSession,DurationSession,FrequencyId,MachineId,StretcherId")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FrequencyId = new SelectList(db.Frequency, "Id", "Id", treatment.FrequencyId);
            ViewBag.MachineId = new SelectList(db.Machine, "Id", "Description", treatment.MachineId);
            ViewBag.StretcherId = new SelectList(db.Stretcher, "Id", "Descrption", treatment.StretcherId);
            return View(treatment);
        }

        // GET: Treatments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db.Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // POST: Treatments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Treatment treatment = db.Treatment.Find(id);
            db.Treatment.Remove(treatment);
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
