using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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
        //public ActionResult Index(int id)
        //{
        //    var idPaciente = id;
        //    //ViewData["IDP"] = id;
        //    Patient paciente = db.Patient.Find(id);
        //    ViewBag.UserName = paciente.Name;
        //    ViewBag.LastName = paciente.LastName;
        //    //var res = (from element in db.FollowupTreatments).GroupBy(x => x.TrackingNumber).Select().OrderBy(x => x.Date);
        //    var grupo = db.FollowupTreatments.GroupBy(x => x.TrackingNumber, (key, g) => g.OrderBy(e => e.Date).Where(p => p.PatientId == id).FirstOrDefault());
        //    //var grupoo = 

        //    //var tratamiento = (from c in db.FollowupTreatments orderby c.TreatmentId descending select c.TreatmentId).First();
        //    var followupTreatments = db.FollowupTreatments.Include(f => f.Patient).Include(f => f.Treatment).Include(f => f.User);
        //    //return View(followupTreatments.ToList().Where(p => p.PatientId == id && p.TreatmentId == (from c in db.FollowupTreatments orderby c.TreatmentId descending select c.TreatmentId).Last()));
        //    //return View(grupo.Where(p => p.PatientId == id));
        //    //var grupoTnumber = from c in db.FollowupTreatments group c by c.TrackingNumber;
        //    //return View(followupTreatments.ToList().Where(p => p.PatientId == id).Last());
        //    return View(grupo.ToList());
        //}
        //GET: FollowupTreatments
        public ActionResult Index(int id)
        {
            var idPaciente = id;

            Patient paciente = db.Patient.Find(id);
            ViewBag.UserName = paciente.Name;
            ViewBag.LastName = paciente.LastName;
            var fTreatment = db.FollowupTreatments.Include(u => u.Patient).Include(u => u.Treatment).Include(u => u.User);
            var param = new SqlParameter("@param1", id);
            var segTratamientos = db.Database.SqlQuery<FollowupTreatment>("dbo.UltimoRegistroTratamientos @param1", param);
            
            return View(segTratamientos.ToList());
        }

        public ActionResult session(int id, int nsesion, int esteticista, int tratamiento, int paciente, int tnum)
        {
            ViewBag.PatientId = paciente;
            ViewBag.TreatmentId = tratamiento;
            ViewBag.UserId = esteticista;
         
            Treatment treatment = db.Treatment.Find(tratamiento);
            ViewBag.Treatment = treatment.Description;
            User user = db.Users.Find(esteticista);
            ViewBag.User = user.Name;
            ViewBag.UserLast = user.LastName;
            int sesion = nsesion + 1;
            ViewBag.NSession = sesion;
            ViewBag.Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult session([Bind(Include = "Id, Commentary")] FollowupTreatment followupTreatment, int nsesion, int esteticista, int tratamiento, int paciente, int tnum)
        {
            
            int sesion = nsesion + 1;
            if (ModelState.IsValid)
            {
                followupTreatment.Date = DateTime.Now;
                followupTreatment.PatientId = paciente;
                followupTreatment.SessionNumber = sesion;
                followupTreatment.UserId = esteticista;
                followupTreatment.TreatmentId = tratamiento;
                followupTreatment.TrackingNumber = tnum;
                db.FollowupTreatments.Add(followupTreatment);
                db.SaveChanges();
                return RedirectToAction("Index", new {id =  paciente});
            }

            Treatment treatment = db.Treatment.Find(tratamiento);
            ViewBag.Treatment = treatment.Description;
            User user = db.Users.Find(esteticista);
            ViewBag.User = user.Name;
            ViewBag.UserLast = user.LastName;
            ViewBag.NSession = sesion;
            return View(followupTreatment);
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
        public ActionResult historialTratamiento(int nseg, int tratamiento)
        {
            var followupTreatments = db.FollowupTreatments.Include(f => f.Patient).Include(f => f.Treatment).Include(f => f.User);
            Treatment treatment = db.Treatment.Find(tratamiento);
            ViewBag.Treatment = treatment.Description;
            return View(followupTreatments.ToList().Where(x => x.TrackingNumber == nseg));
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
        public ActionResult Create([Bind(Include = "Id,TreatmentId,SessionNumber,UserId,Commentary")] FollowupTreatment followupTreatment, int idP)
        {
            Random tNumber = new Random();
            int tn = tNumber.Next(0,100);
            followupTreatment.TrackingNumber = tn;
            followupTreatment.PatientId = idP;
            followupTreatment.SessionNumber = 1;
            if (ModelState.IsValid)
            {
                db.FollowupTreatments.Add(followupTreatment);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = idP});
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
