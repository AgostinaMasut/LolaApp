using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Patient 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string DNI { get; set; }
        public string SexId { get; set; }
        public  Sex Sex { get; set; }
        public int BodyMeasurementsHistoryId { get; set; }
        public  BodyMeasurementsHistory BodyMeasurementsHistory { get; set; }
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
