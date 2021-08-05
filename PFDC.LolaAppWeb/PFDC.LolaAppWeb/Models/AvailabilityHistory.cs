using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class AvailabilityHistory 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProfessionalTimelineId { get; set; }
        public  ProfessionalTimeline ProfessionalTimeline { get; set; }
        public DateTime Day { get; set; }
        public DateTime Hour { get; set; }
        public bool Occupied { get; set; }
        public bool Cancelled { get; set; }
    }
}
