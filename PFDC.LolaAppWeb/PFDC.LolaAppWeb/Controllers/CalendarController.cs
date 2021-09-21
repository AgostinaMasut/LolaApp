using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using DHTMLX.Scheduler;
using DHTMLX.Common;
using DHTMLX.Scheduler.Data;
using DHTMLX.Scheduler.Controls;

using PFDC.LolaAppWeb.Models;
using PFDC.LolaAppWeb.Data;

namespace PFDC.LolaAppWeb.Controllers
{
    public class CalendarController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();
        public ActionResult Index()
        {
            var agenda = new AgendaView(); // initializes the view
            agenda.TabStyle = "Material";
            agenda.TabPosition = 5;
            var scheduler = new DHXScheduler(this);
            scheduler.Views.Add(agenda);
            scheduler.Skin = DHXScheduler.Skins.Material;
            scheduler.InitialDate = DateTime.Now;
            scheduler.LoadData = true;
            scheduler.EnableDataprocessor = true;
            //scheduler.Config.details_on_dblclick = false;
            scheduler.Config.month_date = "%F %Y";
            scheduler.Config.day_date = "%l";
            scheduler.Config.week_date = "%l";
            
            scheduler.Config.first_hour = 9;
            scheduler.Config.last_hour = 19;
            

            return View(scheduler);
        }

        public ContentResult Data()
        {
            //var data = new SchedulerAjaxData();
            //return (ContentResult)data;
            return (new SchedulerAjaxData(
                db.CalendarEvents.Select(e => new { e.id, e.text, e.start_date, e.end_date})
                )
                );
        }

        public ContentResult Save(int? id, FormCollection actionValues)
        {
            var action = new DataAction(actionValues);
            try
            {
                var changedEvent = (CalendarEvent)DHXEventsHelper.Bind(typeof(CalendarEvent), actionValues);

                switch (action.Type)
                {
                    case DataActionTypes.Insert:
                        //do insert
                        //action.TargetId = changedEvent.id;//assign postoperational id
                        //entities.Events.Add(changedEvent);
                        db.CalendarEvents.Add(changedEvent);
                        break;
                    case DataActionTypes.Delete:
                        changedEvent = db.CalendarEvents.FirstOrDefault(ev => ev.id == action.SourceId);
                        db.CalendarEvents.Remove(changedEvent);
                        break;
                    default:// "update"                          
                        //do update
                        var target = db.CalendarEvents.Single(e => e.id == changedEvent.id);
                        DHXEventsHelper.Update(target, changedEvent, new List<string> { "id" });
                        break;
                }
                db.SaveChanges();
                action.TargetId = changedEvent.id;
            }
            catch
            {
                action.Type = DataActionTypes.Error;
            }
            return new AjaxSaveResponse(action);
        }
    }
}

