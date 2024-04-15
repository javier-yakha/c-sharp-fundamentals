using Fundamentals.Exercism.Object;
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
            RailFenceCipher cipher2 = new(2);
            Console.WriteLine(cipher2.Encode("XOXOXOXOXO"));

            RailFenceCipher cipher3 = new(3);
            Console.WriteLine(cipher3.Encode("WEAREDISCOVEREDFLEEATONCE"));
            var msg3 = "TEITELHDVLSNHDTISEIIEA";

            RailFenceCipher cipher4 = new(4);
            Console.WriteLine(cipher4.Encode("EXERCISES"));

            RailFenceCipher cipher5 = new(5);
            var msg5 = "EIEXMSMESAORIWSCE";

            RailFenceCipher cipher6 = new(6);
            var msg6 = "133714114238148966225439541018335470986172518171757571896261";

        }
    }
}