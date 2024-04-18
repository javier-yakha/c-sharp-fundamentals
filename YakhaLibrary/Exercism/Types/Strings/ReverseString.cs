using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Strings
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += input[^(i + 1)];
            }
            return output;
        }
    }
}
