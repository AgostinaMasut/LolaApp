using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFDC.LolaAppWeb.Models
{
    public class CommentCrm 
    {
        public int Id { get; set; }
        public int CrmId { get; set; }
        public Crm Crm { get; set; }
        public string ContactDate { get; set; }
        public string AnswerDate { get; set; }
        public string Commentary { get; set; }

    }
}
