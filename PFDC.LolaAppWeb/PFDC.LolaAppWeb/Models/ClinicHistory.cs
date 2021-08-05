using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDC.LolaAppWeb.Models
{
    public class ClinicHistory
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public  Patient Patient { get; set; }
        public int TurnId { get; set; }
        public  Turn Turn { get; set; }
        public int UserId { get; set; }
        public  User User { get; set; }
        public string Commentary { get; set; }
        public byte Cirugia { get; set; }
        public byte Photo { get; set; }
        public byte Video { get; set; }
        public int FollowupTreatmentId { get; set; }
        public  FollowupTreatment FollowupTreatment { get; set; }
        public int SurgeryProtocolId { get; set; }
        public  SurgeryProtocol SurgeryProtocol { get; set; }

    }
}
