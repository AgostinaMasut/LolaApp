using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LolaWebApp_Base.WebUi.Models
{
    public class UserViewModel : ModelBase
    {
        public int Id { get; set; }

        [Required()]
        [MaxLength(50)]
        [Display(Description = "Nombre")]
        public string Name { get; set; }

        [Required()]
        [Display(Description = "Apellido")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El DNI es obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos")]
        [StringLength(8, ErrorMessage = "El número es demasiado largo")]
        public int DNI { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El cuil es obligatorio")]
        //[RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos ni guiones")]
        [StringLength(12, ErrorMessage = "El número es demasiado largo")]
        [Display(Description = "Cuit o Cuil")]
        public string CuitCuil { get; set; }

        [Display(Description = "Fecha de Nacimiento")]
        public DateTime Birthday { get; set; }

        [Required()]
        [Display(Description = "Calle")]
        public string Street { get; set; }

        [Required()]
        [Display(Description = "N°")]
        public int StreetNumber { get; set; }
        [Display(Description = "Barrio")]
        public string Neighbourhood { get; set; }
        [Display(Description = "Codigo postal")]
        public int ZipCode { get; set; }

        [Required()]
        [Display(Description = "Localidad")]
        public string City { get; set; }
        [Display(Description = "Teléfono")]
        public int Mobile { get; set; }

        [Required()]
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required()]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required()]
        [Display(Description = "Habilitar usuario")]
        public byte Enable { get; set; }
        [Required()]
        public SelectList UserType { get; set; }
        public SelectList Sex { get; set; }
    }
}