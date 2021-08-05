using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Assistance 
    {
        public int Id { get; set; }
        public int TurnId { get; set; }
        public  Turn Turn { get; set; }
        public int AssistanceTypeId { get; set; }
        public  AssistanceType AssistanceType { get; set; }


    }
}
