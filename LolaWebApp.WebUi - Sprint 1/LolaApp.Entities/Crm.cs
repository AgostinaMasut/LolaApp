using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Crm : EntityBase
    {
        public int Id { get; set; }
        public int IdConsultantType { get; set; }
        public int IdTrearmentType { get; set; }
        public int IdMediaType { get; set; }
        public int IdPatient { get; set; }
        public int IdUser { get; set; }

    }
}
