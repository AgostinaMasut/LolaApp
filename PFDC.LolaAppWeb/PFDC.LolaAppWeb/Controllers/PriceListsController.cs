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
    public class PriceListsController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: PriceLists
        public ActionResult Index()
        {
            var priceList = db.PriceList.Include(p => p.Treatment);
            return View(priceList.ToList());
        }

        // GET: PriceLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceList priceList = db.PriceList.Find(id);
            if (priceList == null)
            {
                return HttpNotFound();
            }
            return View(priceList);
        }

        // GET: PriceLists/Create
        public ActionResult Create()
        {
            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description");
            return View();
        }

        // POST: PriceLists/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TreatmentId,Cost,SalePrice,ProfessionalPorcent")] PriceList priceList)
        {
            if (ModelState.IsValid)
            {
                db.PriceList.Add(priceList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description", priceList.TreatmentId);
            return View(priceList);
        }

        // GET: PriceLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceList priceList = db.PriceList.Find(id);
            if (priceList == null)
            {
                return HttpNotFound();
            }
            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description", priceList.TreatmentId);
            return View(priceList);
        }

        // POST: PriceLists/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TreatmentId,Cost,SalePrice,ProfessionalPorcent")] PriceList priceList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(priceList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TreatmentId = new SelectList(db.Treatment, "Id", "Description", priceList.TreatmentId);
            return View(priceList);
        }

        // GET: PriceLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriceList priceList = db.PriceList.Find(id);
            if (priceList == null)
            {
                return HttpNotFound();
            }
            return View(priceList);
        }

        // POST: PriceLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PriceList priceList = db.PriceList.Find(id);
            db.PriceList.Remove(priceList);
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
