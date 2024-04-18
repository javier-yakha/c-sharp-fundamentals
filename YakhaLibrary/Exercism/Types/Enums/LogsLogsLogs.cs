using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Enums
{
    public class LogsLogsLogs
    {
        public enum LogLevel
        {
            Trace = 1,
            Debug = 2,
            Info = 4,
            Warning = 5,
            Error = 6,
            Fatal = 42,
            Unknown = 0
        }
        public static class LogLine
        {
            public static LogLevel ParseLogLevel(string logLine)
            {
                int index = logLine.IndexOf('[') + 1;
                string line = logLine.Substring(index, 3);
                return line switch
                {
                    "TRC" => LogLevel.Trace,
                    "DBG" => LogLevel.Debug,
                    "INF" => LogLevel.Info,
                    "WRN" => LogLevel.Warning,
                    "ERR" => LogLevel.Error,
                    "FTL" => LogLevel.Fatal,
                    _ => LogLevel.Unknown
                };
            }
            public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
        }
    }
}
