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
        public string Surname { get; set; }
        public int DNI { get; set; }
        public string IdSex { get; set; }
        public int BodyMeasurements { get; set; }
        public DateTime DateBirth { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Neighborhood { get; set; }
        public int CP { get; set; }
        public string Location { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
    }
}
