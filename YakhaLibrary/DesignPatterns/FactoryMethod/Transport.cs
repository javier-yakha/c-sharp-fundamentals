using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.DesignPatterns.FactoryMethod
{
    public abstract class Transport
    {
        public string Customer { get; set; } = "Pepito";
        public string Destination { get; set; } = "Antarctica";
        public void CollectProductFromCustomer()
        {
            Console.WriteLine("Picked up the goods\n");
        }
        public abstract void TransportGoods();
    }
}
