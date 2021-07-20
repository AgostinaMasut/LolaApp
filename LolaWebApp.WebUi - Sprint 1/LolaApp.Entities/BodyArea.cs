﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class BodyArea : EntityBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
