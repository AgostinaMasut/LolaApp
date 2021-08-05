using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class Frequency 
    {
        public int Id { get; set; }
        public int BodyAreaId { get; set; }
        public  BodyArea BodyArea { get; set; }
        public int Amount { get; set; }
    }
}
