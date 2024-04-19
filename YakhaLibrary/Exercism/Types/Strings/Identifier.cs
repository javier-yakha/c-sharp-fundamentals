using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Strings
{
    // TODO : Learn StringBuilder
    // partially owned code
    public static class Identifier
    {
        private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');
        public static string Clean(string identifier)
        {
            StringBuilder sb = new();
            bool dash = false;
            foreach (var c in identifier)
            {
                if (char.IsWhiteSpace(c)) sb.Append('_');
                else if (char.IsControl(c)) sb.Append("CTRL");
                else if (IsGreekLowercase(c)) continue;
                else if (dash) sb.Append(char.ToUpperInvariant(c));
                else if (char.IsLetter(c)) sb.Append(c);
                dash = c == '-';
            }
            return sb.ToString();
        }
    }
}
