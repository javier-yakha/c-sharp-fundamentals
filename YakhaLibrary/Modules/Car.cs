using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules
{
    public class Car
    {
        public string color = "Red"; // Class members
        public int yearOfMaking; // declaring a variable
        public static string colorStatic = "Yellow";

        public Car()
        {
            Console.WriteLine(colorStatic);
        }
        public Car(int yearOfMaking)
        {
            this.yearOfMaking = yearOfMaking; // defining a variable
            Console.WriteLine(yearOfMaking);
        }
        public Car(string color)
        {
            this.color = color;
        }

        public void printColor()
        {
            Console.WriteLine(color);
        }
        public void printColor(string color)
        {
            Console.WriteLine(color);
        }
    }
}
