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

            // CollatzConjecture.Steps(16);
            // CollatzConjecture.StepsR(16);
            int[] input = [1, 2];
            int resR = BinarySearch.FindR(input, 0, 0, input.Length - 1);
            int res = BinarySearch.Find(input, 0);

            Console.WriteLine(resR);
            Console.WriteLine(res);
        }
    }
}