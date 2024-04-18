using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.CollectionsY
{
    public static class ResistorColor
    {
        public static int ColorCode(string color) => Array.IndexOf(Colors(), color);
        public static string[] Colors() => ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
    }
}
