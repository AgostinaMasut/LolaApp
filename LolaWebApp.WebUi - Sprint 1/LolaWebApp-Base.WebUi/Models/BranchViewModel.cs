using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolaWebApp_Base.WebUi.Models
{
    public class BranchViewModel
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