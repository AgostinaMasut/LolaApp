using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PFDC.LolaAppWeb.Models
{
    public class Turn
    {
        public int Id { get; set; }

        [Required()]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required()]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
        //public DateTime Hora { get; set; }
        [DisplayName("Tratamiento")]
        public int TreatmentId { get; set; }
        public  Treatment Treatment { get; set; }

        //public int ProfessionalTimelineId { get; set; }
        //public ProfessionalTimeline ProfessionalTimeline { get; set; }

        [DisplayName("Tipo de consulta")]
        public int QueryTypeId { get; set; }
        public QueryType QueryType { get; set; }

        //[DisplayName("Sucursal")]
        //public int BranchId { get; set; }
        //public Branch Branch { get; set; }

        [DisplayName("Asistecia")]
        public int AssistanceTypeId { get; set; }
        public AssistanceType AssistanceType { get; set; }

        public int? PatientId { get; set; }
        public Patient Patient { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Commentary { get; set; }
    }
}
