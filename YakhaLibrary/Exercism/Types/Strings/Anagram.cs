using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Strings
{
    public class Anagram
    {
        public string BaseWord;
        public Anagram(string baseWord)
        {
            BaseWord = baseWord.ToLower();
        }
        public string[] FindAnagrams(string[] potentialMatches)
        {
            List<string> res = [];
            foreach (string potentialMatch in potentialMatches)
            {
                string lowerMatch = potentialMatch.ToLower();
                if (BaseWord.Length != potentialMatch.Length || lowerMatch.Equals(BaseWord)) continue;
                if (CompareArrays(BaseWord, lowerMatch)) res.Add(potentialMatch);
            }
            return [..res];
        }
        private static bool CompareArrays(string baseWord, string compareWord)
        {
            var bw = compareWord.Split();
            foreach (var i in bw) Console.WriteLine(bw.Length);
            Array.Sort(bw);
            foreach (var i in bw) Console.WriteLine(i);
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] != array2[i]) return false;
            //}
            return true;
        }
    }
}
