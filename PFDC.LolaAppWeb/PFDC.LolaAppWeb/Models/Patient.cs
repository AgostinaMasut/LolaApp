using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PFDC.LolaAppWeb.Models
{
    public class Patient 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [DisplayName("Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos")]
        [StringLength(8, ErrorMessage = "El número es demasiado largo")]
        public string DNI { get; set; }
        public string SexId { get; set; }
        public Sex Sex { get; set; }
        //[DisplayName("Hitorial de medidas")]
        //public int BodyMeasurementsHistoryId { get; set; }
        //public  BodyMeasurementsHistory BodyMeasurementsHistory { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime Birthday { get; set; }
        [Required()]
        [DisplayName("Calle")]
        public string Street { get; set; }

        [Required()]
        [DisplayName("N°")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos ni guiones")]
        public int StreetNumber { get; set; }

        [DisplayName("Barrio")]
        public string Neighbourhood { get; set; }

        [DisplayName("Codigo postal")]
        public int ZipCode { get; set; }

        [Required()]
        [DisplayName("Localidad")]
        public string City { get; set; }

        [DisplayName("Teléfono")]
        public string Mobile { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
