using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PFDC.LolaAppWeb.Models
{
    public class PreviousAntecedents
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public  Patient Patient { get; set; }
        public int BackgroundTypeId { get; set; }
        public  BackgroundType BackgroundType { get; set; }
        public string Commentary { get; set; }

    }
}
