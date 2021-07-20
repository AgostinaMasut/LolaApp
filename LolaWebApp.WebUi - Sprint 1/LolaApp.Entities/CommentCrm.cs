using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class CommentCrm : EntityBase
    {
        public int Id { get; set; }
        public int IdCrm { get; set; }
        public string ContactDate { get; set; }
        public string AnswerDate { get; set; }
        public string Commentary { get; set; }

    }
}
