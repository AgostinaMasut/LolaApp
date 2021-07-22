using LolaApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaApp.Entities
{
    public class SurgeryConsent : EntityBase
    {
        public int Id { get; set; }
        public int IdSurgeriesType { get; set; }
        [ForeignKey("IdSurgeriesType")]
        public virtual SurgeriesType SurgeriesType { get; set; }
        public int IdRiskSurgery { get; set; }
        [ForeignKey("IdRiskSurgery")]
        public virtual RiskSurgery RiskSurgeryrType { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("Patient")]
        public virtual Patient Patient { get; set; }

    }
}
