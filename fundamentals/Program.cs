namespace Fundamentals
{

    class MyFirstProgram
    {

        public static void Main(string[] args)
        {
            Car BMW = new Car(1998);
            Console.WriteLine(BMW.color);
            BMW.printColor();
            BMW.printColor("Yellow");

            Car audi = new Car(1994);
            Console.WriteLine(audi.color);

        }
    }
}