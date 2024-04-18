using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules.Inheritance
{
    class Vehicle
    {
        string brand = "Ford";
        public virtual void WriteClass()
        {
            Console.WriteLine("base class - ", brand);
        }
    }
    class Car : Vehicle // syntax of inheritance
    {
        string color = "Red";
        public override void WriteClass()
        {
            Console.WriteLine("Derived class - ", color);
        }
        // public abstract void nonAbstractMethod(); // Error <---> can't create abstract methods on non-abstract classes
    }
    class Bicycle : Vehicle
    {
        public override void WriteClass()
        {
            Console.WriteLine("Non overriden method");
        }
    }
}
