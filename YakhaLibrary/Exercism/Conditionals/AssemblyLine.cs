using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Conditionals
{
    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            // Dict for scalability <-> could also be an array
            return speed switch
            {
                0 => 0,
                1 or 2 or 3 or 4 => 1,
                5 or 6 or 7 or 8 => 0.9,
                9 => 0.8,
                10 => 0.77,
                _ => throw new ArgumentOutOfRangeException()
            }; ;
        }
        public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * (speed * 221);
        public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
    }

}
