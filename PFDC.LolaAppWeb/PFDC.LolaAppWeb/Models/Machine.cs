using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public int MachineTypeId { get; set; }
        public MachineType MachineType { get; set; }

    }
}
