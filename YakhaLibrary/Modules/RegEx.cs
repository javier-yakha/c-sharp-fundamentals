using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules
{
    public class RegEx
    {
        static string pattern = "[a-z]+@[a-z]{3,}\\.(com$|xyz$|de$)";
        public static void RegExMatching()
        {
            Regex obj = new(pattern);
            if (obj.IsMatch("newemail@whatever.xyzs"))
            {
                Console.WriteLine("Matches");
            }
            else
            {
                Console.WriteLine("Doesn't match");
            }
        }
    }
}
