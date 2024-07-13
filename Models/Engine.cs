using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Models
{
    internal class Engine
    {
        public string? Type { get; set; }
        public int HorsePower { get; set; }
        public string? FuelType { get; set; }
        public int Torque { get; set; }
        public float Displacement { get; set; }
    }
}
