using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class PriceList : EntityBase
    {
        public int Id { get; set; }
        public int IdTreatment { get; set; }
        public int Cost { get; set; }
        public int SalePrice { get; set; }
        public int PercentageOfProsseional { get; set; }
    }
}
