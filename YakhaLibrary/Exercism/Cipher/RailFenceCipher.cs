using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Cipher
{
    public class RailFenceCipher
    {
        public int Rails;
        public RailFenceCipher(int rails)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(rails, 1);
            Rails = rails;
        }
        public string Encode(string input)
        {
            string output = "";
            string[] levels = new string[Rails];
            int counter = 0;
            bool downwards = true;
            for (int i = 0; i < input.Length; i++)
            {
                levels[counter] += input[i];

                if (downwards && counter + 1 >= Rails)
                {
                    counter--;
                    downwards = !downwards;
                }
                else if (downwards) counter++;

                else if (counter - 1 < 0)
                {
                    counter++;
                    downwards = !downwards;
                }
                else counter--;
            }
            foreach (string level in levels)
            {
                output += level;
            }
            return output;
        }
        public string Decode(string input)
        {
            return string.Empty;
        }
    }
}
