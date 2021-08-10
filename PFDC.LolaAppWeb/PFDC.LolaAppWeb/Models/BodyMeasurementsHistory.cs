using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class BodyMeasurementsHistory 
    {
        public int Id { get; set; }
        [DisplayName("Fecha de medición")]
        public DateTime MeasurementDate { get; set; }
        public int PatientId { get; set; }
        public  Patient Patient { get; set; }
        [DisplayName("Tipo de medida corporal")]
        public int MeasurementsBodyTypeId { get; set; }
        public  MeasurementsBodyType MeasurementsBodyType { get; set; }
        [DisplayName("Centímetro/gramos")]
        public int CmGr { get; set; }
    }
}
