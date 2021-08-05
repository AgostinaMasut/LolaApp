using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [DisplayName("Apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos")]
        [StringLength(8, ErrorMessage = "El número es demasiado largo")]
        public string DNI { get; set; }
        
        [Required(ErrorMessage = "El cuil/cuit es obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos ni guiones")]
        [StringLength(12, ErrorMessage = "El número es demasiado largo")]
        [DisplayName("Cuit o Cuil")]
        public string CuitCuil { get; set; }
        
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

        [Required()]
        [DataType(DataType.Password)]
        [DisplayName("Contraseña")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Las contraseñas deben ser iguales")]
        [DataType(DataType.Password)]
        [DisplayName("Confirmar contraseña")]
        public string PasswordConfirm { get; set; }

        [Required()]
        [DisplayName("Habilitar usuario")]
        public bool Enable { get; set; }

        [Required(ErrorMessage = "El tipo de usuario es obligatorio")]
        [DisplayName("Tipo de usuario")]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }

        [DisplayName("Sexo")]
        public int SexId { get; set; }
        public Sex Sex { get; set; }
    }
}