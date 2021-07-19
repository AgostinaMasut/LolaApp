using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LolaWebApp_Base.WebUi.Models
{
    public class TurnViewModel : ModelBase
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int IdTreatment { get; set; }
        //[ForeignKey("IdTreatment")]
        //public virtual Treatment Treatment { get; set; }
        public int IdProfessionalTimeline { get; set; }
        //[ForeignKey("IdProfessionalTimeline")]
        //public virtual ProfessionalTimeline ProfessionalTimeline { get; set; }
        public int IdStretcherAvailability { get; set; }
        //[ForeignKey("IdStretcherAvailability")]
        //public virtual StretcherAvailability StretcherAvailability { get; set; }
        public int IdMachineAvailability { get; set; }
        //[ForeignKey("IdMachineAvailability")]
        //public virtual MachineAvailability MachineAvailability { get; set; }
        public int IdTypeOfQuery { get; set; }
        //[ForeignKey("IdTypeOfQuery")]
        //public virtual TypeOfQuery TypeOfQuery { get; set; }
        public int IdBranch { get; set; }
        //[ForeignKey("IdBranch")]
        //public virtual Branch Branch { get; set; }
        public int IdAvailabilityOfSurgeries { get; set; }
        //[ForeignKey("IdAvailabilityOfSurgeries")]
        //public virtual AvailabilityOfSurgeries AvailabilityOfSurgeries { get; set; }

    }
}
