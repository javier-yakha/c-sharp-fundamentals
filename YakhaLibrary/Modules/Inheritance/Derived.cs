using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YakhaLibrary.Modules.Inheritance
{
    public class Baseclass
    {
        public void fun()
        {
            Console.Write("Base class" + " ");
        }
    }
    public class Derived1 : Baseclass
    {
        new void fun()
        {
            Console.Write("Derived1 class" + " ");
        }
    }
    public class Derived2 : Derived1
    {
        new void fun()
        {
            Console.Write("Derived2 class" + " ");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Derived2 d = new Derived2();
            d.fun();
        }
    }
}


