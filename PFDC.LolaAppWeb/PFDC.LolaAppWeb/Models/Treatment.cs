using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Description { get; set; }
        [DisplayName("Cantidad de sesiones")]
        public int AmountSession { get; set; }
        [DisplayName("Duración de la sesion")]
        public int DurationSession { get; set; }
        [DisplayName("Frecuencia por zona del cuerpo")]
        public int FrequencyId { get; set; }
        public Frequency Frequency { get; set; }
        [DisplayName("Maquina")]
        public int MachineId { get; set; }
        public Machine Machine { get; set; }
        [DisplayName("Camilla")]
        public int StretcherId { get; set; }
        public  Stretcher Stretcher { get; set; }
    }
}
