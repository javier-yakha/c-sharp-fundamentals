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
        static Regex isValidRE = new("^[[](TRC|DBG|INF|WRN|ERR|FTL)[]]");
        static Regex splitLogLineRegex = new("<[-=*^]+>", RegexOptions.IgnoreCase);
        static Regex countQuotedPasswordsRegex = new("\".*password.*\"", RegexOptions.IgnoreCase);
        static Regex removeEndOfLineTextRegex = new("end-of-line[0-9]+");
        static Regex listLinesWithPasswordsRegex = new(@"password[\w\d]+", RegexOptions.IgnoreCase);
        public bool IsValidLine(string text) => isValidRE.IsMatch(text);
        public string[] SplitLogLine(string text) => splitLogLineRegex.Split(text);
        public int CountQuotedPasswords(string lines) => countQuotedPasswordsRegex.Count(lines);
        public string RemoveEndOfLineText(string line) => removeEndOfLineTextRegex.Replace(line, "");
        public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] res = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                var parsedLine = listLinesWithPasswordsRegex.Match(lines[i]);
                res[i] = parsedLine.Length > 0 ? $"{parsedLine}: {lines[i]}" : $"--------: {lines[i]}";
            }
            return res;
        }
    }

}
