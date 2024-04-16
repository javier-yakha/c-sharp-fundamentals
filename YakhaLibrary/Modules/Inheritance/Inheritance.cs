using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YakhaLibrary.Modules;

namespace YakhaLibrary.Modules.Inheritance
{
    public static class Inheritance
    {
        public static void Inherit()
        {
            Vehicle spaceship = new();
            Car ford = new();
            Bicycle mountainBike = new();

            spaceship.WriteClass();
            ford.WriteClass();
            mountainBike.WriteClass();

            // Animal animal = new(); // Gives error <--> abstract class
            Dog cachupin = new();
            Pig chanchitoFeliz = new();

            cachupin.MakeSound();
            chanchitoFeliz.MakeSound();
        }

    }
}
