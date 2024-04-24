using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Cipher
{
    public static class RotationalCipher
    {
        // 65 - 90
        // 97 - 122
        public static string Rotate(string text, int shiftKey)
        {
            string res = "";
            shiftKey %= 26;
            // Short Version
            // TODO : How to do this with Linq
            foreach (var c in text) res += Convert.ToChar(char.IsLower(c) ? ((c + shiftKey > 122 ? ((c + shiftKey) % 122) + 96 : c + shiftKey)) : char.IsUpper(c) ? (c + shiftKey > 90 ? ((c + shiftKey) % 90) + 64 : c + shiftKey) : c);

            // Long Version
            // foreach (var c in text)
            // {
            //     var r = c + shiftKey;
            //     if (char.IsLower(c)) r = r > 122 ? (r % 122) + 96 : r;
            //     else if (char.IsUpper(c)) r = r > 90 ? (r % 90) + 64 : r;
            //     else r = c;
            //     res += Convert.ToChar(r);
            // }
            return res;
        }
    }
}
