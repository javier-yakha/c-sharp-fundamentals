using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Basic
{
    static class Badge
    {
        public static string Print(int? id, string name, string? department)
        {
            string dpt = (department ?? "owner").ToUpper();
            if (id == null) return $"{name} - {dpt}";
            return $"[{id}] - {name} - {dpt}";
        }
    }
}
