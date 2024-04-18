using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;
using YakhaLibrary.Exercism.Recursion;

namespace Fundamentals
{

    class MyFirstProgram
    {

        public static void Main(string[] args)
        {
            // Inheritance.Inherit();

            // Enums.Enumerate();

            int res = CollatzConjecture.Steps(16);
            Console.WriteLine(res);
        }
    }
}