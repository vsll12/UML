using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Interfaces;
using UML.Models;

namespace UML.Services
{
    internal class CarBuilder : Builder
    {
        private Car? car { get; set; }
        public void Reset()
        {
            this.car = new Car();
        }

        public void SetEngine(Engine engine)
        {
            this.car!.Engine = engine;   
        }

        public void SetGPS()
        {
            throw new NotImplementedException();
        }

        public void SetSeats(int number)
        {
            this.car!.NumberOfSeats = number;
        }

        public void SetTripComputer()
        {
            throw new NotImplementedException();
        }

        public Car GetResult() 
        {
            return this.car!;
        }

    }
}
