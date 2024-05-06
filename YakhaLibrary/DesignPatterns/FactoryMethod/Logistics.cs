using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.DesignPatterns.FactoryMethod
{
    public abstract class Logistics
    {
        // Creation is abstracted into the Concrete Creator
        protected abstract Transport TransportFactory(string transportType);
        public Transport ManageTransportForCustomer()
        {
            Console.Write("Which route would you like to use to deliver this goods?");
            Console.WriteLine();

            string transportType = string.Empty;
            var input = Console.ReadLine();
            if (input is not null) transportType = input;

            Console.WriteLine();

            Transport transport = TransportFactory(transportType);

            // Operation is separated from the Creation
            transport.CollectProductFromCustomer();
            transport.TransportGoods();

            return transport;
        }

    }
}
