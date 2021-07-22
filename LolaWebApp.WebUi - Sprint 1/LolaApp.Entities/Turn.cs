using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Turn : EntityBase
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int IdTreatment { get; set; }
        [ForeignKey("IdTreatment")]
        public virtual Treatment Treatment { get; set; }
        public int IdProfessionalTimeline { get; set; }
        [ForeignKey("IdProfessionalTimeline")]
        public virtual ProfessionalTimeline ProfessionalTimeline { get; set; }
        public int IdStretcherAvailability { get; set; }
        [ForeignKey("IdStretcherAvailability")]
        public virtual StretcherAvailability StretcherAvailability { get; set; }
        public int IdMachineAvailability { get; set; }
        [ForeignKey("IdMachineAvailability")]
        public virtual MachineAvailability MachineAvailability { get; set; }
        public int IdQueryType { get; set; }
        [ForeignKey("IdQueryType")]
        public virtual QueryType QueryType { get; set; }
        public int IdBranch { get; set; }
        [ForeignKey("IdBranch")]
        public virtual Branch Branch { get; set; }
        public int IdSurgeriesAvailability { get; set; }
        [ForeignKey("IdSurgeriesAvailability")]
        public virtual SurgeriesAvailability SurgeriesAvailability { get; set; }

    }
}
