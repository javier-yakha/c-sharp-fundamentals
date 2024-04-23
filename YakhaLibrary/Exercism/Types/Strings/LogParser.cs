using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Strings
{
    public class LogParser
    {
        static string isValidLineRegex = "^[[](TRC|DBG|INF|WRN|ERR|FTL)[]]";
        static string splitLogLineRegex = "<[=-*^]+>";
        static string countQuotedPasswordsRegex = """password""";
        public bool IsValidLine(string text)
            {
                Regex regex = new(isValidLineRegex);
                return regex.IsMatch(text);
            }

        public string[] SplitLogLine(string text)
        {
            Regex regex = new(splitLogLineRegex);
            return regex.Split(text);
        }

        public int CountQuotedPasswords(string lines)
        {
            Regex regex = new(countQuotedPasswordsRegex);
            return regex.Count(lines);
        }

        public string RemoveEndOfLineText(string line)
        {
            throw new NotImplementedException($"Please implement the LogParser.RemoveEndOfLineText() method");
        }

        public string[] ListLinesWithPasswords(string[] lines)
        {
            throw new NotImplementedException($"Please implement the LogParser.ListLinesWithPasswords() method");
        }
    }

}
