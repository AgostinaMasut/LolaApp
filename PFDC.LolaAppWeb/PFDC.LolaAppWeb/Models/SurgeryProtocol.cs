using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class SurgeryProtocol
    {
        public int Id { get; set; }
        public int StepNumber { get; set; }
        public string Commentary { get; set; }
        //public int PatientId { get; set; }
        //public  Patient Patient { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
    }
}
