﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Exercism.Basic
{
    public class Lasagna
    {
        public int ExpectedMinutesInOven() => 40;

        public int RemainingMinutesInOven(int minutes) => ExpectedMinutesInOven() - minutes;

        public int PreparationTimeInMinutes(int layers) => 2 * layers;

        public int ElapsedTimeInMinutes(int layers, int minutes) => layers * 2 + minutes;

    }


}