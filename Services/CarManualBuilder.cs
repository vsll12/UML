using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Interfaces;
using UML.Models;

namespace UML.Services
{
    internal class CarManualBuilder : Builder
    {
        public Manual? manual{ get; set; }
        public void Reset()
        {
            this.manual = new Manual();
        }

        public void SetEngine(Engine engine)
        {
            this.manual!.Engine = engine;
        }

        public void SetGPS()
        {
            throw new NotImplementedException();
        }

        public void SetSeats(int number)
        {
            this.manual!.NumberOfSeats = number;
        }

        public void SetTripComputer()
        {
            throw new NotImplementedException();
        }

        public Manual GetResult()
        {
            return this.manual!;
        }
    }
}
