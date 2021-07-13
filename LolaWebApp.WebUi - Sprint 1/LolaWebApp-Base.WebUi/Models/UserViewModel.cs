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
        public string Name { get; set; }

        [Required()]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El DNI es obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos")]
        [StringLength(8, ErrorMessage = "El número es demasiado largo")]
        public int DNI { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El cuil es obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números, sin puntos ni guiones")]
        [StringLength(12, ErrorMessage = "El número es demasiado largo")]
        public string CuitCuil { get; set; }
        public DateTime Birthday { get; set; }

        [Required()]
        public string Street { get; set; }

        [Required()]
        public int StreetNumber { get; set; }
        public string Neighbourhood { get; set; }
        public int ZipCode { get; set; }

        [Required()]
        public string City { get; set; }
        public int Mobile { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required()]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required()]
        public bool Enable { get; set; }
        [Required()]
        public SelectList UserType { get; set; }
        public SelectList Sex { get; set; }
    }
}