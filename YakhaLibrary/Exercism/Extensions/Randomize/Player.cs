﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Extensions.Randomize
{
    public static class Player
    {
        public static int RollDie()
        {
            Random r = new();
            return r.Next(1, 18);
        }

        public static double GenerateSpellStrength()
        {
            Random r = new();
            return r.NextDouble() * 100d;
        }
    }
}
