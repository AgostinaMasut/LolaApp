using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Tipo de antecedente")]
        public int BackgroundTypeId { get; set; }
        public BackgroundType BackgroundType { get; set; }
        [DisplayName("Comentario")]
        public string Commentary { get; set; }

    }
}
