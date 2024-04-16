using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;
using YakhaLibrary.Exercism.Object;
using YakhaLibrary.Modules;
using YakhaLibrary.Modules.Inheritance;
namespace Fundamentals
{

    class MyFirstProgram
    {

        public static void Main(string[] args)
        {
            /*
            Car BMW = new Car(1998);
            Console.WriteLine(BMW.color);
            BMW.printColor();
            BMW.printColor("Yellow");

            Car audi = new Car(1994);
            Console.WriteLine(audi.color);
            */

            //RailFenceCipher cipher2 = new(2);
            //string enco2 = cipher2.Encode("XOXOXOXOXO");
            //Console.WriteLine(enco2);
            //Console.WriteLine(cipher2.Decode(enco2));

            //RailFenceCipher cipher3 = new(3);
            //string enco3 = cipher3.Encode("WEAREDISCOVEREDFLEEATONCE");
            //Console.WriteLine(enco3);
            //Console.WriteLine(cipher3.Decode(enco3));

            //RailFenceCipher cipher4 = new(4);
            //string enco4 = cipher4.Encode("EXERCISES");
            //Console.WriteLine(enco4);
            //Console.WriteLine(cipher4.Decode(enco4));

            //RailFenceCipher cipher5 = new(5);
            //var msg5 = "EIEXMSMESAORIWSCE";
            //Console.WriteLine(cipher5.Decode(msg5));

            //RailFenceCipher cipher6 = new(6);
            //var msg6 = "133714114238148966225439541018335470986172518171757571896261";
            //Console.WriteLine(msg6.Length);
            //Console.WriteLine(cipher6.Decode(msg6));


            Inheritance.Inherit();

            Enums.Enumerate();
        }
    }
}