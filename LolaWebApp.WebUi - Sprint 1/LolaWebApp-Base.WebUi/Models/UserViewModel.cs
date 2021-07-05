using System;
using System.Collections.Generic;

namespace LolaWebApp_Base.WebUi.Models
{
    public class UserViewModel : ModelBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int CuitCuil { get; set; }
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

        public List<UserTypeViewModel> TipoUsuario = new List<UserTypeViewModel>();

        public List<SexViewModel> Sexo = new List<SexViewModel>();
    }
}