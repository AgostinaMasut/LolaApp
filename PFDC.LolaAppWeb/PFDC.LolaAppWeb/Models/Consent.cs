using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Consent 
    {
        public int Id { get; set; }
        public int TreatmentId { get; set; }
        public  Treatment Treatment { get; set; }
        public int RisksId { get; set; }
        public  Risks Risks { get; set; }
        public int AestheticPathologiesId { get; set; }
        public  AestheticPathologies AestheticPathologies { get; set; }

    }
}
