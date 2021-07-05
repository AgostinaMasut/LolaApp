using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolaWebApp_Base.WebUi.Models
{
    public class ProfessionalTimelineViewModel
    {
        public int Id { get; set; }
        public string Dia { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Salida { get; set; }
        public int IdUser { get; set; }
        public int IdBranch { get; set; }
     
    }
}