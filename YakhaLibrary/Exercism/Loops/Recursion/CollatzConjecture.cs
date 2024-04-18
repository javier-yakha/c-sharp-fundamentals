using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Loops.Recursion
{
    public static class CollatzConjecture
    {
        public static int StepsR(int number)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);
            if (number == 1) return 0;
            if (number % 2 == 0) return 1 + StepsR(number / 2);
            return 1 + StepsR(number * 3 + 1);
        }
        public static int Steps(int number)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(number);
            int count = 0;
            while (number != 1)
            {
                if (number % 2 == 0) number /= 2;
                else number = number * 3 + 1;
                count++;
            }
            return count;
        }
    }
}
