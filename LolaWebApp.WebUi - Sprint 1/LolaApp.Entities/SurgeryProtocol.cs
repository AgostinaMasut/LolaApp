using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class SurgeryProtocol : EntityBase
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdTreatmentType { get; set; }
        public string Commentary { get; set; }

    }
}
