using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //public int UserId { get; set; }
        //public  User User { get; set; }
        [DisplayName("Comentario")]
        public string Commentary { get; set; }

        [DisplayName("Cirugía")]
        public byte Surgery { get; set; }

        [DisplayName("Foto")]
        public byte Photo { get; set; }

        [DisplayName("Video")]
        public byte Video { get; set; }

        //[DisplayName("Seguimiento de tratamiento")]
        //public int FollowupTreatmentId { get; set; }
        //public FollowupTreatment FollowupTreatment { get; set; }

        [DisplayName("Cirugía")]
        public int? SurgeryProtocolId { get; set; }
        public  SurgeryProtocol SurgeryProtocol { get; set; }

    }
}
