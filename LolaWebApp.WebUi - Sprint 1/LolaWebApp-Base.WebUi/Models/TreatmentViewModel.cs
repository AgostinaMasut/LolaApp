using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LolaWebApp_Base.WebUi.Models
{
    public class TreatmentViewModel : ModelBase
    {
        public int Id { get; set; }
        public int IdProtocol { get; set; }
        public int IdUser { get; set; }
        public int IdPatient { get; set; }
    }
}