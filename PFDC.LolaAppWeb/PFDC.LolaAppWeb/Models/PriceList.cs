using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class PriceList 
    {
        public int Id { get; set; }
        public int TreatmentId { get; set; }
        public  Treatment Treatment { get; set; }
        public int Cost { get; set; }
        public int SalePrice { get; set; }
        public int ProfessionalPorcent { get; set; }
    }
}
