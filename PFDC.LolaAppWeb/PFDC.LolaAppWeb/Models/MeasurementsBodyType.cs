using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class MeasurementsBodyType
    {
        public int Id { get; set; }
        [DisplayName("Medida corporal")]
        public string Description { get; set; }
    }
}
