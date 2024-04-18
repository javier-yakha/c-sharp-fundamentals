using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Strings
{
    public static class Bob
    {
        public static string Response(string statement)
        {
            statement = statement.TrimEnd();
            bool silence = string.Equals(statement, string.Empty);
            if (silence) return "Fine. Be that way!";

            bool alpha = false;
            foreach (char c in statement)
            {
                if (char.IsLetter(c)) alpha = true;
            }
            bool yelling = string.Equals(statement, statement.ToUpper()) && alpha;

            bool question = statement[^1] == '?';
            if (yelling && question) return "Calm down, I know what I'm doing!";
            if (question) return "Sure.";
            if (yelling) return "Whoa, chill out!";
            return "Whatever.";
        }
    }
}
