using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class BackgroundType 
    {
        public int Id { get; set; }

        [DisplayName("Tipo de antecedente")]
        public string Description { get; set; }

    }
}
