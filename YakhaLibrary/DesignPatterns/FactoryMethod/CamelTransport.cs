using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.DesignPatterns.FactoryMethod
{
    public class CamelTransport : Transport
    {
        public override void TransportGoods()
        {
            Console.WriteLine($"Goods have been collected from {Customer} and transported to: {Destination} by the Camel route");
        }
    }
}
