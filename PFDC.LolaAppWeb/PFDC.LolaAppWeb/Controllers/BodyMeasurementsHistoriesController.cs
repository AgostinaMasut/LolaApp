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
    public class BodyMeasurementsHistoriesController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: BodyMeasurementsHistories
        public ActionResult Index()
        {
            var bodyMeasurementsHistory = db.BodyMeasurementsHistory.Include(b => b.MeasurementsBodyType).Include(b => b.Patient);
            return View(bodyMeasurementsHistory.ToList());
        }

        // GET: BodyMeasurementsHistories
        public ActionResult Measurements(int id)
        {
            ViewBag.MeasurementsBodyTypeId = new SelectList(db.MeasurementsBodyType, "Id", "Description");
            Patient paciente = new Patient();
            ViewBag.PatientName = paciente.Name;
            ViewBag.PatientLastName = paciente.LastName;
            var bodyMeasurementsHistory = db.BodyMeasurementsHistory.Include(b => b.MeasurementsBodyType).Include(b => b.Patient);
            return View(Tuple.Create <BodyMeasurementsHistory, IEnumerable<BodyMeasurementsHistory>>(new BodyMeasurementsHistory(), bodyMeasurementsHistory.ToList().Where(p => p.PatientId == id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Measurements([Bind(Include = "Id,MeasurementDate,MeasurementsBodyTypeId,CmGr")] BodyMeasurementsHistory bodyMeasurementsHistory, int id)
        {
            var parameter = id;
            if (ModelState.IsValid)
            {
                bodyMeasurementsHistory.PatientId = id;
                db.BodyMeasurementsHistory.Add(bodyMeasurementsHistory);
                db.SaveChanges();
                return RedirectToAction("Measurements", new { parameter});
            }

            ViewBag.MeasurementsBodyTypeId = new SelectList(db.MeasurementsBodyType, "Id", "Description", bodyMeasurementsHistory.MeasurementsBodyTypeId);
            //ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name", bodyMeasurementsHistory.PatientId);
            ViewBag.PatientId = id;
            var bodyMeasurementsHistory2 = db.BodyMeasurementsHistory.Include(b => b.MeasurementsBodyType).Include(b => b.Patient);
            ModelState.AddModelError("Los datos no son correctos", "Vuelva a completar el formulario");
            return View(Tuple.Create<BodyMeasurementsHistory, IEnumerable<BodyMeasurementsHistory>>(new BodyMeasurementsHistory(), bodyMeasurementsHistory2.ToList().Where(p => p.PatientId == id)));

        }
        // GET: BodyMeasurementsHistories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyMeasurementsHistory bodyMeasurementsHistory = db.BodyMeasurementsHistory.Find(id);
            if (bodyMeasurementsHistory == null)
            {
                return HttpNotFound();
            }
            return View(bodyMeasurementsHistory);
        }

        // GET: BodyMeasurementsHistories/Create
        public ActionResult Create()
        {
            ViewBag.MeasurementsBodyTypeId = new SelectList(db.MeasurementsBodyType, "Id", "Description");
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name");
            return View();
        }

        // POST: BodyMeasurementsHistories/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MeasurementDate,PatientId,MeasurementsBodyTypeId,CmGr")] BodyMeasurementsHistory bodyMeasurementsHistory)
        {
            if (ModelState.IsValid)
            {
                db.BodyMeasurementsHistory.Add(bodyMeasurementsHistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MeasurementsBodyTypeId = new SelectList(db.MeasurementsBodyType, "Id", "Description", bodyMeasurementsHistory.MeasurementsBodyTypeId);
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name", bodyMeasurementsHistory.PatientId);
            return View(bodyMeasurementsHistory);
        }

        // GET: BodyMeasurementsHistories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyMeasurementsHistory bodyMeasurementsHistory = db.BodyMeasurementsHistory.Find(id);
            if (bodyMeasurementsHistory == null)
            {
                return HttpNotFound();
            }
            ViewBag.MeasurementsBodyTypeId = new SelectList(db.MeasurementsBodyType, "Id", "Description", bodyMeasurementsHistory.MeasurementsBodyTypeId);
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name", bodyMeasurementsHistory.PatientId);
            return View(bodyMeasurementsHistory);
        }

        // POST: BodyMeasurementsHistories/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MeasurementDate,PatientId,MeasurementsBodyTypeId,CmGr")] BodyMeasurementsHistory bodyMeasurementsHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bodyMeasurementsHistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MeasurementsBodyTypeId = new SelectList(db.MeasurementsBodyType, "Id", "Description", bodyMeasurementsHistory.MeasurementsBodyTypeId);
            ViewBag.PatientId = new SelectList(db.Patient, "Id", "Name", bodyMeasurementsHistory.PatientId);
            return View(bodyMeasurementsHistory);
        }

        // GET: BodyMeasurementsHistories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyMeasurementsHistory bodyMeasurementsHistory = db.BodyMeasurementsHistory.Find(id);
            if (bodyMeasurementsHistory == null)
            {
                return HttpNotFound();
            }
            return View(bodyMeasurementsHistory);
        }

        // POST: BodyMeasurementsHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BodyMeasurementsHistory bodyMeasurementsHistory = db.BodyMeasurementsHistory.Find(id);
            db.BodyMeasurementsHistory.Remove(bodyMeasurementsHistory);
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
