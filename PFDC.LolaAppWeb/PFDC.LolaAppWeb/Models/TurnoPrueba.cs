using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Models
{
    public class TurnoPrueba
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}