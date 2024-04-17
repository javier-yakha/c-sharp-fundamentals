using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules
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
        /*
        // Data Types

        // 0, 255 unsigned integer 8-bit
        byte byteData = 5; 

        // +-32,768 signed integer 16-bit
        short shortData = 30000; 

        // +- 2,147,483,648 signed integer 32-bit
        int intData = 141241; 

        // single precision 32-bit
        float floatData = 0.5f; 

        // double precision 64-bit
        double doubleData = 0.5141d; 

        // triple? precision 128-bit - for financial or monetary operations
        decimal decimalData = 124.12535141m; 

        // logical true/false -- default is false
        bool boolData = true; 

        // single character 16-bit unicode
        char charData = 'z'; 
        
        // series of unicode characters
        string stringData = "hello world"; 

        // date object
        DateTime date = new DateTime(); 
        */
    }
}
