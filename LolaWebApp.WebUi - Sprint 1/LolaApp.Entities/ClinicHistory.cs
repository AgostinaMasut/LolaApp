using LolaApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaApp.Entities
{
    public class ClinicHistory : EntityBase
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }
        public int IdTurn { get; set; }
        [ForeignKey("IdTurn")]
        public virtual Turn Turn { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
        public string Commentary { get; set; }
        public byte Cirugia { get; set; }
        public byte Photo { get; set; }
        public byte Video { get; set; }
        public int IdFollowupTreatment { get; set; }
        [ForeignKey("IdFollowupTreatment")]
        public virtual FollowupTreatment FollowupTreatment { get; set; }
        public int IdSurgeryProtocol { get; set; }
        [ForeignKey("IdSurgeryProtocol")]
        public virtual SurgeryProtocol SurgeryProtocol { get; set; }

    }
}
