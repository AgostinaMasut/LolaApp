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
    public class ConfigurationController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();
        // GET: Configuration
        public ActionResult Index()
        {
            ViewBag.FrequencyId = new SelectList(db.Frequency, "Id", "Id");
            ViewBag.MachineId = new SelectList(db.Machine, "Id", "Description");
            ViewBag.StretcherId = new SelectList(db.Stretcher, "Id", "Descrption");
            return View(Tuple.Create<Stretcher,Machine,Branch,Treatment>(new Stretcher(),new Machine(), new Branch(), new Treatment() ));
            

        }
    }
}