using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Models
{
    public class Branch
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [DisplayName("Número de teléfono")]
        public string PhoneNumber { get; set; }
        [DisplayName("Calle")]
        public string Street { get; set; }

        [DisplayName("N°")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos ni guiones")]
        public int StreetNumber { get; set; }
        [DisplayName("Barrio")]
        public string Neighbourhood { get; set; }
        [DisplayName("Código postal")]
        public int ZipCode { get; set; }
        [DisplayName("Localidad")]
        public string City { get; set; }
    }
}