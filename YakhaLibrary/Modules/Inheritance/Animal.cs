using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules.Inheritance
{
    abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep()
        {
            Console.WriteLine("Zzz...");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }
    class Pig : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Wee wee");
        }
    }
}
