using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML.Services;
using UML.Models;


namespace UML.Models
{
    internal class Client
    {

        public Director director = new Director();

        public CarBuilder carBuilder = new CarBuilder();

        public Client() 
        {
            director.MakeSportsCar(carBuilder);

            Car car = carBuilder.GetResult();
        }
    }
}
