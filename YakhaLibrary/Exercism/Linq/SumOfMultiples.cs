using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Linq
{
    public static class SumOfMultiples
    {
        // Taken from community
        // TODO : More on LINQ
        public static int Sum(IEnumerable<int> multiples, int max) => Enumerable.Range(0, max)
            .Where(num => multiples
                   .Any(multiple => multiple != 0
                        && num % multiple == 0)
                  )
            .Sum();

    }
}
