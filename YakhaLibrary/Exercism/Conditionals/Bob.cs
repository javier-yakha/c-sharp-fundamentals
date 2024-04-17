using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Conditionals
{
    public static class Bob
    {
        public static string Response(string statement)
        {
            bool question = statement[^1] == '?';
            bool yelling = string.Equals(statement.ToUpper(CultureInfo.InvariantCulture), statement);
            bool silence = string.Equals(statement, string.Empty);

            if (yelling && question) return "Calm down, I know what I'm doing!";
            if (question) return "Sure.";
            if (yelling) return "Whoa, chill out!";
            if (silence) return "Fine. Be that way!";
            else return "Whatever.";
        }
    }
}
