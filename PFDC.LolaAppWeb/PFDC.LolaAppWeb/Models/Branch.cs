using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Neighbourhood { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
    }
}