using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Consent : EntityBase
    {
        public int Id { get; set; }
        public int IdTreatment { get; set; }
        [ForeignKey("IdTreatment")]
        public virtual Treatment Treatment { get; set; }
        public int IdRisks { get; set; }
        [ForeignKey("IdRisks")]
        public virtual Risks Risks { get; set; }
        public int IdAestheticPathologies { get; set; }
        [ForeignKey("IdAestheticPathologies")]
        public virtual AestheticPathologies AestheticPathologies { get; set; }

    }
}
