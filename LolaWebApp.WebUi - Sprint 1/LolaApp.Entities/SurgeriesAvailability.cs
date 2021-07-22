using LolaApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaApp.Entities
{
    public class SurgeriesAvailability : EntityBase
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }
        public int IdSurgeriesType { get; set; }
        [ForeignKey("IdSurgeriesType")]
        public virtual SurgeriesType SurgeriesType { get; set; }
        public DateTime Day { get; set; }
        public DateTime Hour { get; set; }
        public bool Occupied { get; set; }

    }
}
