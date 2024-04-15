using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Car
    {
        public string color = "Red"; // Class members
        public int yearOfMaking; // declaring a variable

        public Car(int year)
        {
            yearOfMaking = year; // defining a variable
            Console.WriteLine(yearOfMaking);
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
