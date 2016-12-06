using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer.Implementation.Validator
{
    /// <summary>
    /// Handles validating the password field
    /// </summary>
    public class PasswordValidation
    {
        public static bool Validate(string password)
        {
            return password.Trim().Length > 6;
        }
    }
}
