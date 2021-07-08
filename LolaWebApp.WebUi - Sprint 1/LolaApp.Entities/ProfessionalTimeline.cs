using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class ProfessionalTimeline : EntityBase
    {
        public int Id { get; set; }
        public string Dia { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public int? IdUser { get; set; }
        //[ForeignKey("IdUser")]
        public virtual User User { get; set; }
        public int? IdBranch { get; set; }
        [ForeignKey("IdBranch")]
        public virtual Branch Branch { get; set; } 

       //ver si le ponemos el historial de disponibilidad
    }
}
