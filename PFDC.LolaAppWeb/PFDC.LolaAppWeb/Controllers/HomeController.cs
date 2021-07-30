using PFDC.LolaAppWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PFDC.LolaAppWeb.Models;

namespace PFDC.LolaAppWeb.Controllers
{
    public class HomeController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();
        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Calendar()
        //{
        //    //ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        //public ActionResult GetCalendarData()
        //{

        //    List<Calendar> data = new List<Calendar>();

        //    //Statically create list and add data  
        //    Calendar infoObj1 = new Calendar();
        //    infoObj1.Id = 1;
        //    infoObj1.Title = "I am available";
        //    infoObj1.Desc = "Description 1";
        //    infoObj1.Start_Date = "2020-08-16 22:37:22.467";
        //    infoObj1.End_Date = "2020-08-16 23:30:22.467";
        //    db.Calendar.Add(infoObj1);

        //    return Json(data, JsonRequestBehavior.AllowGet);

        //}


        //[HttpPost]
        //public ActionResult UpdateCalanderData([Bind(Include = "Id,Title,Desc,Start_Date,End_Date")] Calendar model)
        //{
        //    var id = model.Id;
        //    db.Calendar.Add(model);
        //    db.SaveChanges();
        //    return Json(id, JsonRequestBehavior.AllowGet);
        //}

    }
}
