using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Branch : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PhoneNumber { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Neighbourhood { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }


    }
}
