using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules
{
    public static class Enums
    {
        enum Months
        {
            January = 1, // 1
            February,    // 2
            March,       // 3
            April,       // 4
            May,         // 5
            June,        // 6
            July,        // 7
            August,      // 8
            September,   // 9
            October,     // 10
            November,    // 11
            December     // 12
        }

        enum Unnamed
        {
            None,           // 0
            zero,           // 1
            one,            // 2
            more,           // 3
            many,           // 4
            some,           // 5
            exactly = 300,  // 300
            lessExact,      // 301
            genau           // 302
        }

        public static void Enumerate()
        {
            int month = (int)Months.March;
            Console.WriteLine(month);

            int genau = (int)Unnamed.genau;
            Console.WriteLine(genau);
        }
    }
}
