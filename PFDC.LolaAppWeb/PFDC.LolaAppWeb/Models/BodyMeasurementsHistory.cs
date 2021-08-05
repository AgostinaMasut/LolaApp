using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class BodyMeasurementsHistory 
    {
        public int Id { get; set; }
        public DateTime MeasurementDate { get; set; }
        public int PatientId { get; set; }
        public  Patient Patient { get; set; }
        public int MeasurementsBodyTypeId { get; set; }
        public  MeasurementsBodyType MeasurementsBodyType { get; set; }

        public int CmGr { get; set; }
    }
}
