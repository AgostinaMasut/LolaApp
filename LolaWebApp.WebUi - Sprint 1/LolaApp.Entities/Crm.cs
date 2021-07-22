using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;

namespace LolaApp.Entities
{
    public class Crm : EntityBase
    {
        public int Id { get; set; }
        public int IdConsultantType { get; set; }
        [ForeignKey("IdConsultantType")]
        public virtual ConsultantType ConsultantType { get; set; }
        public int IdMediaType { get; set; }
        [ForeignKey("IdMediaType")]
        public virtual MediaType MediaType { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

    }
}
