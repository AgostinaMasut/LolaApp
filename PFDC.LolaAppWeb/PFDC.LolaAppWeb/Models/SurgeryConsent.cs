
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDC.LolaAppWeb.Models
{
    public class SurgeryConsent
    {
        public int Id { get; set; }
        public int SurgeriesTypeId { get; set; }
        public  SurgeriesType SurgeriesType { get; set; }
        public int RiskSurgeryId { get; set; }
        public virtual RiskSurgery RiskSurgeryrType { get; set; }
        public int PatientId { get; set; }
        public  Patient Patient { get; set; }

    }
}
