using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    /// <summary>
    /// Simple program showcasing basics of C#
    /// </summary>
    public class Fundamental
    {
        public Fundamental()
        {
            // Writing to console
            Console.WriteLine("Hello World!");
            Console.WriteLine(8 + 6);
            Console.WriteLine("8 + 6");
            Console.Write("Hi ");
            Console.Write(" Hello ");

            // Commenting
            // string name = Console.ReadLine();
            string name = "Six Plus Eight";
            /*
            Console.WriteLine(name);
            Console.WriteLine("Hello, " + name);
            */

            // Math Operators
            int num = 1;
            Console.WriteLine(num++); // Prints num and then increments
            Console.WriteLine(++num); // increments and then prints num
            num += 5;
            Console.WriteLine(num);

            // String
            string txt = "We are the so called \"Vikings\"\nfrom the north.";
            Console.WriteLine(txt);

            Console.ReadLine();
        }

        // Data Types
        byte byteData = 5; // 0, 255 unsigned integer 8-bit
        short shortData = 30000; // +-32,768 signed integer 16-bit
        int intData = 141241; // +- 2,147,483,648 signed integer 32-bit
        float floatData = 0.5f; // single precision 32-bit
        double doubleData = 0.5141d; // double precision 64-bit
        decimal decimalData = 124.12535141m; // triple? precision 128-bit - for financial or monetary operations
        bool boolData = true; // logical true/false -- default is false
        char charData = 'z'; // single character 16-bit unicode
        string stringData = "hello world"; // series of unicode characters
        DateTime date = new DateTime(); // date object
    }
}
