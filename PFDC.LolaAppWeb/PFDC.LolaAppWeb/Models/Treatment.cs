using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Treatment 
    {
        public int Id { get; set; }
        public int ProtocolId { get; set; }
        public  Protocol Protocol { get; set; }
        public int UserId { get; set; }
        public  User User { get; set; }
        public int PatientId { get; set; }
        public  Patient Patient { get; set; }
    }
}
