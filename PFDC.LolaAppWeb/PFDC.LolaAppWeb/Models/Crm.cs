using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDC.LolaAppWeb.Models
{
    public class Crm 
    {
        public int Id { get; set; }
        public int ConsultantTypeId { get; set; }
        public  ConsultantType ConsultantType { get; set; }
        public int MediaTypeId { get; set; }
        public  MediaType MediaType { get; set; }
        public int PatientId { get; set; }
        public  Patient Patient { get; set; }
        public int UserId { get; set; }
        public  User User { get; set; }

    }
}
