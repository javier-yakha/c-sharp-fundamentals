using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Conditionals
{
    public static class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();
            int count = 0;
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i]) count++;
            }
            return count;
        }
    }
}
