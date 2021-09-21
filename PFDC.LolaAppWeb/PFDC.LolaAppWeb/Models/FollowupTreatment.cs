using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFDC.LolaAppWeb.Models
{
    public class FollowupTreatment
    {
        public int Id { get; set; }

        public int TrackingNumber { get; set; }

        [Required()]
        [DisplayName("Tratamiento")]
        public int TreatmentId { get; set; }
        public Treatment Treatment { get; set; }

        [Required()]
        [DisplayName("Número de sesion")]
        public int SessionNumber { get; set; }

        [Required()]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        //public int TurnId { get; set; }
        //public Turn Turn { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        [DisplayName("Comentario")]
        public string Commentary { get; set; }
    }
}