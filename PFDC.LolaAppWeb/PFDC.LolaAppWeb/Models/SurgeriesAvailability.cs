
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDC.LolaAppWeb.Models
{
    public class SurgeriesAvailability 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public  User User { get; set; }
        public int SurgeriesTypeId { get; set; }
        public  SurgeriesType SurgeriesType { get; set; }
        public DateTime Day { get; set; }
        public DateTime Hour { get; set; }
        public bool Occupied { get; set; }

    }
}
