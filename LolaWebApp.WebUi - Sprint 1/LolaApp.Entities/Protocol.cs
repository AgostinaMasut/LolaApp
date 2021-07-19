﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolaApp.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolaApp.Entities
{
    public class Protocol : EntityBase
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int IdTypeTreatment { get; set; }
        public int NumberSession { get; set; }
        public int DurationSession { get; set; }
        public int IdFrequency { get; set; }
        public int IdMachineType { get; set; }
        public int IdStretcher { get; set; }
    }
}