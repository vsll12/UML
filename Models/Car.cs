using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Models
{
    internal class Car
    {
        public string? Model { get; set; }
        public string? Vendor { get; set; }
        public string? Color { get; set; }
        public double Price { get; set; }
        public int NumberOfSeats { get; set; }
        public Engine? Engine { get; set; }
    }
}
