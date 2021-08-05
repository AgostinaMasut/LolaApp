using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class MeasurementsBodyType 
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
