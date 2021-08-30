using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Models
{
    public class ProfessionalTimeline
    {


        public int Id { get; set; }

        [Required()]
        [DisplayName("Día")]
        public Days Day { get; set; }

        [Required()]
        [DataType(DataType.Time)]
        //[DisplayFormat(DataFormatString = "{0:HH:mm}")]
        [DisplayName("Hora de ingreso")]
        public DateTime Input { get; set; }

        [Required()]
        [DataType(DataType.Time)]
        //[DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DisplayName("Hora de salida")]
        public DateTime Output { get; set; }
        
        [Required()]
        public int UserId { get; set; }
        public User User { get; set; }
        
        [Required()]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }

    public enum Days
    {
        Lunes = 1, Martes = 2,  Miércoles = 3, Jueves = 4, Viernes = 5, Sábado = 6
    }
}