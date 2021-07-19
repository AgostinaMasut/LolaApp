using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class BodyMeasurements : EntityBase
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdMedicalHistoryMedicine { get; set; }
        public int IdAestheticClinicalHistory { get; set; }
        public int Height_cm { get; set; }
        public int Weigth_gr { get; set; }
        public int Imc { get; set; }
        public int Supraumbilical { get; set; }
        public int Infraumbilical { get; set; }
        public int Umbilical { get; set; }
        public int LeftThigh { get; set; }
        public int RightThigh { get; set; }

    }
}
