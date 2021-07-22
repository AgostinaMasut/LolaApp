using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Patient : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string DNI { get; set; }
        public string IdSex { get; set; }
        [ForeignKey("IdSex")]
        public virtual Sex Sex { get; set; }
        public int IdBodyMeasurementsHistory { get; set; }
        [ForeignKey("IdBodyMeasurementsHistory")]
        public virtual BodyMeasurementsHistory BodyMeasurementsHistory { get; set; }
        public DateTime DateBirth { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string Location { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
    }
}
