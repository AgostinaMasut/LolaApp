using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Turn
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int TreatmentId { get; set; }
        public  Treatment Treatment { get; set; }
        public int ProfessionalTimelineId { get; set; }
        public  ProfessionalTimeline ProfessionalTimeline { get; set; }
        public int StretcherAvailabilityId { get; set; }
        public  StretcherAvailability StretcherAvailability { get; set; }
        public int MachineAvailabilityId { get; set; }
        public  MachineAvailability MachineAvailability { get; set; }
        public int QueryTypeId { get; set; }
        public  QueryType QueryType { get; set; }
        public int BranchId { get; set; }
        public  Branch Branch { get; set; }
        public int SurgeriesAvailabilityId { get; set; }
        public  SurgeriesAvailability SurgeriesAvailability { get; set; }

    }
}
