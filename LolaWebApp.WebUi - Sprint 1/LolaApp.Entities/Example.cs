using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Example : EntityBase
    {
        public int Id { get; set; }

        //Referencia a otra entity
        //public int IdPropiedad { get; set; }
        //[ForeingKey("IdPropiedad")]
        //public virtual NombreEntity NombreEntity { get; set; }

    }
}
