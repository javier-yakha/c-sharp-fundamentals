using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Strings
{
    public static class HighSchoolSweethearts
    {
        public static string DisplaySingleLine(string studentA, string studentB) => $"{studentA,29} ♡ {studentB,-29}";
        public static string DisplayBanner(string studentA, string studentB) => String.Format(@"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {0} +  {1}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *", studentA, studentB);
        public static string DisplayGermanExchangeStudents(string studentA
            , string studentB, DateTime start, float hours) => 
            String.Format(CultureInfo.GetCultureInfo("de-DE"),
                    "{0} and {1} have been dating since {2:d} - that's {3:N2} hours",
                    studentA, studentB, start, hours);
            // Alternative approach from exercism
            /*
             * var german = CultureInfo.GetCultureInfo("de-DE");
             * return $"{studentA} and {studentB} have been dating since {start:dd.MM.yyyy} - that's {hours.ToString("N2", german)} hours";
             */
    }
}
