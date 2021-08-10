using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class PriceList 
    {
        public int Id { get; set; }
        [DisplayName("Tratamiento")]
        public int TreatmentId { get; set; }
        public  Treatment Treatment { get; set; }
        [DisplayName("Costo")]
        public int Cost { get; set; }
        [DisplayName("Precio de venta")]
        public int SalePrice { get; set; }
        [DisplayName("Porcentaje profesional")]
        public int ProfessionalPorcent { get; set; }
    }
}
