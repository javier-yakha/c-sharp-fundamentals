using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Object
{
    public class RailFenceCipher
    {
        int rails;
        public RailFenceCipher(int rails)
        {
            if (rails < 1) throw new ArgumentOutOfRangeException(nameof(rails));
            this.rails = rails;
        }

        public string Encode(string input)
        {
            string output = "";
            string[] levels = new string[rails];

            int counter = 0;
            bool downwards = true;

            for (int i = 0; i < input.Length; i++)
            {
                levels[counter] += input[i];

                if (downwards && counter + 1 >= rails)
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
