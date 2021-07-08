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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int CuitCuil { get; set; }
        [Display(Description = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string Calle { get; set; }
        public int NumeroCalle { get; set; }
        public string Barrio { get; set; }
        public int CP { get; set; }
        public string Localidad { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte Habilitado { get; set; }
        public int IdUserType { get; set; }
        public SelectList TipoUsuario { get; set; }

        //public List<UserTypeViewModel> TipoUsuario = new List<UserTypeViewModel>();

        public SelectList Sexo { get; set; }
    }
}