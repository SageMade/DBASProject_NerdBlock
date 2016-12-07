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

        public static bool ValidatePhone(string phoneNumber, ref string errorMsg)
        {
            return true;
        }

        public static bool ValidatePassword(string newPass)
        {
            //throw new NotImplementedException();
            return true;
        }
    }
}
