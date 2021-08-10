using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class AssistanceType
    {
        public int Id { get; set; }

        [DisplayName("Asistencia")]
        public string Description { get; set; }
    }
}
