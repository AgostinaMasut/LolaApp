using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Assistance : EntityBase
    {
        public int Id { get; set; }
        public int IdTurn { get; set; }
        [ForeignKey("IdTurn")]
        public virtual Turn Turn { get; set; }

        public int IdAssistanceType { get; set; }
        [ForeignKey("IdAssistanceType")]
        public virtual AssistanceType AssistanceType { get; set; }


    }
}
