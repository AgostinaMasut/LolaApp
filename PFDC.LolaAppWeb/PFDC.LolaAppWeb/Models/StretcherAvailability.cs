using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class StretcherAvailability
    {
        public int Id { get; set; }
        public int StretcherId { get; set; }
        public  Stretcher Stretcher { get; set; }
        public DateTime Day { get; set; }
        public DateTime Hour { get; set; }
        public bool Occupied { get; set; }
    }
}
