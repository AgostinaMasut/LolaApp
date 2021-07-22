using LolaApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaApp.Entities
{
    public class FollowupTreatment : EntityBase
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }
        public int IdTurn { get; set; }
        [ForeignKey("IdTurn")]
        public virtual Turn Turn { get; set; }
        public int SessionNumber { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
        public string Commentary { get; set; }
        public int IdTreatment { get; set; }
        [ForeignKey("IdTreatment")]
        public virtual Treatment Treatment { get; set; }


    }
}
