using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Branch : EntityBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Calle { get; set; }
        public int NumeroCalle { get; set; }
        public string Barrio { get; set; }
        public int CP { get; set; }
        public string Localidad { get; set; }


    }
}
