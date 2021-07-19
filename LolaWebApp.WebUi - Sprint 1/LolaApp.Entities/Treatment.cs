using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Treatment : EntityBase
    {
        public int Id { get; set; }
        public int IdProtocol { get; set; }
        public int IdUser { get; set; }
        public int IdPatient { get; set; }
    }
}
