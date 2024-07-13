using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Models;

namespace UML.Interfaces
{
    internal interface Builder
    {
        public void Reset();
        public void SetSeats(int number);
        public void SetEngine(Engine engine);
        public void SetTripComputer();
        public void SetGPS();
    }
}
