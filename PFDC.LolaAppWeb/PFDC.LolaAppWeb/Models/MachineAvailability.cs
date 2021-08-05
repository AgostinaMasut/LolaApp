using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class MachineAvailability 
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public  Machine Machine { get; set; }
        public DateTime Day { get; set; }
        public DateTime Hour { get; set; }
        public byte Occuped { get; set; }
    }
}
