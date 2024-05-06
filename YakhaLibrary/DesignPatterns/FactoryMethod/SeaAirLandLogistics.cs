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

            transport = transportType switch
            {
                "land" => new LandTransport(),
                "sea" => new SeaTransport(),
                "air" => new AirTransport(),
                "camel" => new CamelTransport(),
                _ => throw new NotSupportedException($"Route {transportType} is not supported")
            };

            return transport;
        }
    }
}
