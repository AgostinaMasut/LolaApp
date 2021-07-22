using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Frequency : EntityBase
    {
        public int Id { get; set; }
        public int IdBodyArea { get; set; }
        [ForeignKey("IdBodyArea")]
        public virtual BodyArea BodyArea { get; set; }
        public int Amount { get; set; }
    }
}
