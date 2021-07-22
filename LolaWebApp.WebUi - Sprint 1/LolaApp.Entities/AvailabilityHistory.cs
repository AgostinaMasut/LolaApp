using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
   public class AvailabilityHistory : EntityBase
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
        public int IdProfessionalTimeline { get; set; }
        [ForeignKey("IdProfessionalTimeline")]
        public virtual ProfessionalTimeline ProfessionalTimeline { get; set; }
        public DateTime Day { get; set; }
        public DateTime Hour { get; set; }
        public byte Occupied { get; set; }
        public byte Cancelled { get; set; }
    }
}
