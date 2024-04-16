using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Basic
{
    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            // Dict for scalability <-> could also be an array
            Dictionary<int, double> dict = new()
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 1 },
                { 3, 1 },
                { 4, 1 },
                { 5, 0.9 },
                { 6, 0.9 },
                { 7, 0.9 },
                { 8, 0.9 },
                { 9, 0.8 },
                { 10, 0.77 }
            };
            return dict[speed];
        }
        public static double ProductionRatePerHour(int speed) => SuccessRate(speed) * (speed * 221);
        public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
    }

}
