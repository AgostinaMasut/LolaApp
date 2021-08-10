using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDC.LolaAppWeb.Models
{
    public class Crm 
    {
        public int Id { get; set; }
        [DisplayName("Tipo de consultor")]
        public int ConsultantTypeId { get; set; }
        public ConsultantType ConsultantType { get; set; }
        [DisplayName("Medio de comunicación")]
        public int MediaTypeId { get; set; }
        public MediaType MediaType { get; set; }
        [DisplayName("Nombre y apellido")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        [DisplayName("Creador CRM")]
        public int UserId { get; set; }
        public User User { get; set; }
        [DisplayName("Tratamiento consultado")]
        public int TreatmentId { get; set; }
        public Treatment Treatment { get; set; }
        [DisplayName("Cirugía consultada")]
        public int SurgeryProtocolId { get; set; }
        public SurgeryProtocol SurgeryProtocol { get; set; }
    }
}
