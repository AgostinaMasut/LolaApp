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
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DNI { get; set; }
        public int CuitCuil { get; set; }
        public DateTime Birthday { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Neighbourhood { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte Enable { get; set; }
        public int IdUserType { get; set; }
        [ForeignKey("IdUserType")]
        public virtual UserType UserType { get; set; }
        public int IdSex { get; set; }
        [ForeignKey("IdSex")]
        public virtual Sex Sex { get; set; }
       // public int IdBranch { get; set; }
        //[ForeignKey("IdBranch")]
        //public virtual Branch Branch { get; set; }

    }
}
