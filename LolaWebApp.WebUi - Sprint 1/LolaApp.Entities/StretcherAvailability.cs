using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class StretcherAvailability : EntityBase
    {
        public int Id { get; set; }
        public int IdStretcher { get; set; }
        [ForeignKey("IdStretcher")]
        public virtual Stretcher Stretcher { get; set; }
        public DateTime Day { get; set; }
        public DateTime Hour { get; set; }
        public bool Occupied { get; set; }
    }
}
