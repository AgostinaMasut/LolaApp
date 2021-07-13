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
        [Required()]
        public int DNI { get; set; }
        [Required()]
        public int CuitCuil { get; set; }
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
        public string Email { get; set; }
        [Required()]
        public string Password { get; set; }
        [Required()]
        public byte Enable { get; set; }
        [Required()]
        public SelectList UserType { get; set; }
        public SelectList Sex { get; set; }

        //public int Id { get; set; }
        //[Required()]
        //[MaxLength(50)]
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public int DNI { get; set; }
        //public int CuitCuil { get; set; }
        //[Display(Description = "Fecha de Nacimiento")]
        //public DateTime FechaNacimiento { get; set; }
        //public string Calle { get; set; }
        //public int NumeroCalle { get; set; }
        //public string Barrio { get; set; }
        //public int CP { get; set; }
        //public string Localidad { get; set; }
        //public int Celular { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public byte Habilitado { get; set; }
        //public int IdUserType { get; set; }
        //public SelectList TipoUsuario { get; set; }

        ////public List<UserTypeViewModel> TipoUsuario = new List<UserTypeViewModel>();

        //public SelectList Sexo { get; set; }
    }
}