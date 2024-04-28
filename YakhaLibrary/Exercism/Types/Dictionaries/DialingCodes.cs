using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Dictionaries
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();
        public static Dictionary<int, string> GetExistingDictionary() => new Dictionary<int, string>
        {
            {1,"United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            Dictionary<int, string> dc = GetEmptyDictionary();
            dc.Add(countryCode, countryName);
            return dc;
        }
        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary.Add(countryCode, countryName);
            return existingDictionary;
        }
        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.TryGetValue(countryCode, out string countryName) ? countryName : string.Empty;
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.ContainsKey(countryCode);
        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode)) existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }
        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            string longest = "";
            foreach (var pair in existingDictionary)
            {
                if (pair.Value.Length > longest.Length) longest = pair.Value;
            }
            return longest;
        }
    }
}
