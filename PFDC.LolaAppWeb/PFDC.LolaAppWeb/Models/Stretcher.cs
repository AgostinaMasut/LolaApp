using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class Stretcher
    {
        public int Id { get; set; }
        [DisplayName("N° de camilla")]
        public string Descrption { get; set; }
    }
}
