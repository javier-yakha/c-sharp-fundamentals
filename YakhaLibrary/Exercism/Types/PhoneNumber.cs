using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types
{
    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            bool isNewYork = phoneNumber[0] == '2' && phoneNumber[1] == '1' && phoneNumber[2] == '2';
            bool isFake = phoneNumber[4] == '5' && phoneNumber[5] == '5' && phoneNumber[6] == '5';
            string localNumber = phoneNumber.Substring(phoneNumber.Length - 4, 4);
            return (isNewYork, isFake, localNumber);
        }
        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
    }
}
