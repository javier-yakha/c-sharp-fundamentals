using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals.exercism
{
    static class LogLine
    {
        public static string Message(string logLine)
        {
            int idx = logLine.IndexOf(':') + 1;
            return logLine[idx..].Trim();
        }
        public static string LogLevel(string logLine)
        {
            int start = logLine.IndexOf('[') + 1;
            int end = logLine.IndexOf(']');

            return logLine[start..end].ToLower();

        }
        public static string Reformat(string logLine)
        {
            return $"{Message(logLine)} ({LogLevel(logLine)})";
        }
    }

}
