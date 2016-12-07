using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer.Implementation
{
    public static class Validations
    {
        private static Regex myPhoneRegex;
        private static Regex myPostalCodeRegex;

        static Validations()
        {
            myPhoneRegex = new Regex(@"[(]?(\d{3})[)]?[\ -]?(\d{3})[\ -]?(\d{4})");
        }

        public static string ValidatePhone(string phoneNumber, ref string errorMsg)
        {
            if (myPhoneRegex.IsMatch(phoneNumber))
            {
                Match m = myPhoneRegex.Match(phoneNumber);
                return m.Groups[1].Value + m.Groups[2].Value + m.Groups[3].Value;
            }
            else
            {
                errorMsg += "Phone number is invalid\n";
                return null;
            }
        }

        public static bool ValidatePassword(string newPass)
        {
            return newPass.Length >= 6;
        }
    }
}
