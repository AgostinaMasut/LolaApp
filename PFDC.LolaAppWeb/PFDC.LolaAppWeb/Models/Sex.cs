using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Models
{
    public class Sex
    {
        public int Id { get; set; }

        [DisplayName("Sexo")]
        public string Description { get; set; }
    }
}