using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Conditionals
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            string answer = string.Empty;
            for (int i = 0; i < takeDown; i++)
            {
                if (answer != string.Empty) answer += "\n\n";
                if (startBottles > 2) answer += $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\nTake one down and pass it around, {startBottles - 1} bottles of beer on the wall.";
                else if (startBottles == 2) answer += $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\nTake one down and pass it around, {startBottles - 1} bottle of beer on the wall.";
                else if (startBottles == 1) answer += $"{startBottles} bottle of beer on the wall, {startBottles} bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.";
                else answer += $"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
                startBottles--;
            }
            return answer;
        }
    }
}
