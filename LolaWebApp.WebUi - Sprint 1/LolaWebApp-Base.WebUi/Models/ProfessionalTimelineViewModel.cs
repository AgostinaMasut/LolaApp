using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LolaWebApp_Base.WebUi.Models
{
    public class ProfessionalTimelineViewModel
    {
        public int Id { get; set; }
        [Required()]
        public string Day { get; set; }
        [Required()]
        public DateTime Input { get; set; }
        [Required()]
        public DateTime Output { get; set; }
        [Required()]
        public int IdUser { get; set; }
        [Required()]
        public int IdBranch { get; set; }
     
    }
}