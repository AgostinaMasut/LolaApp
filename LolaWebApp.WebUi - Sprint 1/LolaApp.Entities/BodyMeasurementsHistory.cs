using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class BodyMeasurementsHistory : EntityBase
    {
        public int Id { get; set; }
        public DateTime MeasurementDate { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }
        public int IdMeasurementsBodyType { get; set; }
        [ForeignKey("IdMeasurementsBodyType")]
        public virtual MeasurementsBodyType MeasurementsBodyType { get; set; }

        public int CmGr { get; set; }

    }
}
