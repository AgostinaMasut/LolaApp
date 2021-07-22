using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Protocol : EntityBase
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int IdTreatmentType { get; set; }
        [ForeignKey("IdTreatmentType")]
        public virtual TreatmentType TreatmentType { get; set; }
        public int NumberSession { get; set; }
        public int DurationSession { get; set; }
        public int IdFrequency { get; set; }
        [ForeignKey("IdFrequency")]
        public virtual Frequency Frequency { get; set; }
        public int IdMachineType { get; set; }
        [ForeignKey("IdMachineType")]
        public virtual MachineType MachineType { get; set; }
        public int IdStretcher { get; set; }
        [ForeignKey("IdStretcher")]
        public virtual Stretcher Stretcher { get; set; }
    }
}
