using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class User : EntityBase
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
        public int IdUserType { get; set; }
        [ForeignKey("IdUserType")]
        public virtual UserType UserType { get; set; }
        public int IdSex { get; set; }
        [ForeignKey("IdSex")]
        public virtual Sex Sex { get; set; }
        public int IdBranch { get; set; }
        [ForeignKey("IdBranch")]
        public virtual Branch Branch { get; set; }

    }
}
