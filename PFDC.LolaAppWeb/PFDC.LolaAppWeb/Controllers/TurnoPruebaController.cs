using PFDC.LolaAppWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PFDC.LolaAppWeb.Models;
using DHTMLX.Scheduler;
using DHTMLX.Common;
using System.Data.Entity;
using DHTMLX.Scheduler.Data;

namespace PFDC.LolaAppWeb.Controllers
{
    public class TurnoPruebaController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: TurnoPrueba
        public ActionResult Index()
        {
            var scheduler = new DHXScheduler(this);
            scheduler.Skin = DHXScheduler.Skins.Flat;
            scheduler.Config.first_hour = 9;
            scheduler.Config.last_hour = 20;
            scheduler.EnableDynamicLoading(SchedulerDataLoader.DynamicalLoadingMode.Month);
            scheduler.LoadData = true;
            scheduler.EnableDataprocessor = true;
            return View(scheduler);
        }
        public ContentResult Data()
        {
            var apps = db.TurnoPrueba.ToList();
            return new SchedulerAjaxData(apps);
        }

        public ActionResult Save(int? id, FormCollection actionValues)
        {
            var action = new DataAction(actionValues);

            try
            {
                var changedEvent = DHXEventsHelper.Bind<TurnoPrueba>(actionValues);
                switch (action.Type)
                {
                    case DataActionTypes.Insert:
                        db.TurnoPrueba.Add(changedEvent);
                        break;
                    case DataActionTypes.Delete:
                        db.Entry(changedEvent).State = EntityState.Deleted;
                        break;
                    default:// "update"  
                        db.Entry(changedEvent).State = EntityState.Modified;
                        break;
                }
                db.SaveChanges();
                action.TargetId = changedEvent.Id;
            }
            catch (Exception a)
            {
                action.Type = DataActionTypes.Error;
            }

            return (new AjaxSaveResponse(action));
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
