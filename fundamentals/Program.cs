using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;
using YakhaLibrary.Exercism;
using YakhaLibrary.Exercism.Graphs;
using YakhaLibrary.Exercism.Loops.Recursion;
using YakhaLibrary.Exercism.Types.Equalities;
using YakhaLibrary.Exercism.Types.Integrals;
using YakhaLibrary.Exercism.Types.Strings;
using static YakhaLibrary.Exercism.Types.Equalities.Faceid2;

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

            // int[] input = [1, 2, 5, 7, 10, 12, 13, 561];
            // int resR = BinarySearch.FindR(input, 0, 0, input.Length - 1);
            // int res = BinarySearch.Find(input, 0);

            // SimpleLinkedList<int> list = new([1, 3, -5, 8]);
            // list.Reverse();
            // foreach (var i in list) Console.WriteLine(i);

            //Identifier.Clean("à-ḃç");

            //Faceid2 fi2 = new Faceid2();
            //Authenticator auth = new();

            // BinarySearchTree bst = new([ 5, 4 ]);

            byte[] byteArray = TelemetryBuffer.ToBuffer(5);
            foreach (var i in byteArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(UInt32.MinValue);
            Console.WriteLine(UInt32.MaxValue);

            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int32.MaxValue);

            Console.WriteLine(Int64.MinValue);
            Console.WriteLine(Int64.MaxValue);

            Console.ReadLine();
        }   

    }
}