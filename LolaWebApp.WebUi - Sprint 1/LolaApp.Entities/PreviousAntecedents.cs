using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;


namespace LolaApp.Entities
{
    public class PreviousAntecedents : EntityBase
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }
        public int IdBackgroundType { get; set; }
        [ForeignKey("IdBackgroundType")]
        public virtual BackgroundType BackgroundType { get; set; }
        public string Commentary { get; set; }

    }
}
