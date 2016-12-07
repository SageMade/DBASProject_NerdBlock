using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NerdBlock.Engine.Frontend;
using NerdBlock.Engine.Backend.Models;

namespace NerdBlock.Engine.LogicLayer.Implementation
{
    public static class Validations
    {
        private static Regex myPhoneRegex;
        private static Regex myPostalCodeRegex;

        static Validations()
        {
            myPhoneRegex = new Regex(@"[(]?(\d{3})[)]?[\ -]?(\d{3})[\ -]?(\d{4})");
            myPostalCodeRegex = new Regex(@"([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)");
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

        public static Address ValidateAddressFromMap(IoMap map, string prefix, ref string error)
        {
            string myError = "";

            string street = map.GetInput<string>(__Pref(prefix, "Street"));
            string postalCode = map.GetInput<string>(__Pref(prefix, "PostalCode"));
            string city = map.GetInput<string>(__Pref(prefix, "City"));
            string country = map.GetInput<string>(__Pref(prefix, "Country"));
            string state = map.GetInput<string>(__Pref(prefix, "State"));
            string aptNumText = map.GetInput<string>(__Pref(prefix, "AptNum"));

            int aptNum = -1;

            if (string.IsNullOrWhiteSpace(street))
                myError += "You must enter a street address\n";
            if (string.IsNullOrWhiteSpace(postalCode))
                myError += "You must enter a postal code\n";
            if (string.IsNullOrWhiteSpace(city))
                myError += "You must enter a city\n";
            if (string.IsNullOrWhiteSpace(country))
                myError += "You must enter a country\n";
            if (string.IsNullOrWhiteSpace(state))
                myError += "You must enter a state or province\n";

            if (!string.IsNullOrWhiteSpace(aptNumText) && !int.TryParse(aptNumText, out aptNum))
                myError += "Apartment Number must be an integer\n";

            if (myError == "")
            {
                ValidatePostalCode(postalCode, ref myError);
            }

            if (myError == "")
            {
                Address address = new Address()
                {
                    StreetAddress = street,
                    City = city,
                    Country = country,
                    PostalCode = postalCode,
                    State = state
                };
                
                if (!string.IsNullOrWhiteSpace(aptNumText))
                    address.ApartmentNumber = aptNum;

                return address;
            }
            else
            {
                error += myError;
                return null;
            }
        }

        private static void ValidatePostalCode(string postalCode, ref string error)
        {
            if (!myPhoneRegex.IsMatch(postalCode))
            {
                error += "Postal code is invalid\n";
            }
        }

        private static string __Pref(string prefix, string name)
        {
            if (string.IsNullOrEmpty(prefix))
                return name;
            else
                return prefix.Trim() + "." + name;
        }
    }
}
