using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.DesignPatterns.FactoryMethod
{
    public class SeaAirLandLogistics : Logistics
    {
        // Concrete Creation by the ConcreteCreator class
        protected override Transport TransportFactory(string transportType)
        {
            Transport transport;

            if (transportType == "land")
                transport = new LandTransport();

            else if (transportType == "sea")
                transport = new SeaTransport();

            else if (transportType == "air")
                transport = new AirTransport();

            else if (transportType == "camel")
                transport = new CamelTransport();

            else throw new ArgumentException("Invalid route selected");

            return transport;
        }
    }
}
