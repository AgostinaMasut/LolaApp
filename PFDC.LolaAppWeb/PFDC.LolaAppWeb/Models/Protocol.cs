using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Protocol
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TreatmentTypeId { get; set; }
        public TreatmentType TreatmentType { get; set; }
        public int NumberSession { get; set; }
        public int DurationSession { get; set; }
        public int FrequencyId { get; set; }
        public  Frequency Frequency { get; set; }
        public int MachineTypeId { get; set; }
        public  MachineType MachineType { get; set; }
        public int StretcherId { get; set; }
        public  Stretcher Stretcher { get; set; }
    }
}
