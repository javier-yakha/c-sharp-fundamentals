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
        static Regex isValidRE = new Regex("^[[](TRC|DBG|INF|WRN|ERR|FTL)[]]");
        static Regex splitLogLineRegex = new Regex("<[-=*^]+>", RegexOptions.IgnoreCase);
        static Regex countQuotedPasswordsRegex = new Regex("\".*password.*\"", RegexOptions.IgnoreCase);
        static Regex removeEndOfLineTextRegex = new Regex("end-of-line[0-9]+");
        public bool IsValidLine(string text) => isValidRE.IsMatch(text);
        public string[] SplitLogLine(string text) => splitLogLineRegex.Split(text);
        public int CountQuotedPasswords(string lines) => countQuotedPasswordsRegex.Count(lines);
        public string RemoveEndOfLineText(string line) => removeEndOfLineTextRegex.Replace(line, "");
        public string[] ListLinesWithPasswords(string[] lines)
        {
            throw new NotImplementedException($"Please implement the LogParser.ListLinesWithPasswords() method");
        }
    }

}
