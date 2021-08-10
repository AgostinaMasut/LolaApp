using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PFDC.LolaAppWeb.Models
{
    public class Frequency
    {
        public int Id { get; set; }
        [DisplayName("Area del cuerpo")]
        public BodyAreas BodyArea { get; set; }
        [DisplayName("Frecuencia")]
        public int Amount { get; set; }
    }
    public enum BodyAreas
    {
        //Crear enumerable
        Lunes = 1, Martes = 2, Miércoles = 3, Jueves = 4, Viernes = 5, Sábado = 6
    }
}
