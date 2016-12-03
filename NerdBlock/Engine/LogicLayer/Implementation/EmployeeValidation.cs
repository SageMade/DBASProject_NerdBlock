using System;

namespace NerdBlock.Engine.LogicLayer.Implementation
{
    /// <summary>
    /// A business rule that handles validating and updating employees
    /// </summary>
    public class EmployeeValidation : BusinessRule
    {
        public const string ACTION_NAME = "insert_employee";

        /// <summary>
        /// Checks whether this rule allows or disallows an action to be performed. This
        /// is where things like validation can be performed
        /// </summary>
        /// <param name="actionName">The name of the action to check</param>
        /// <param name="reason">The reference to a string that will store the failure reason if applicable</param>
        /// <returns>True if the action can be performed, false if otherwise</returns>
        public override bool CanPerform(string actionName, ref string reason)
        {
            if (actionName.Equals(ACTION_NAME))
            {
                return __CheckEmployeeValid(ref reason);
            }
            return true;
        }

        /// <summary>
        /// Handles checking to see if the employee isntance on the context is valid
        /// </summary>
        /// <param name="reason">The reference to the reason for failure</param>
        /// <returns>True if validation was successful, false if otherwise</returns>
        private bool __CheckEmployeeValid( ref string reason)
        {
            bool result = true;

            string fName = Context.GetValue("FirstName") as string;
            string lName = Context.GetValue("LastName") as string;
            string sin = Context.GetValue("SIN") as string;
            string phone = Context.GetValue("Phone") as string;

            long tempVal = -1;

            if (string.IsNullOrWhiteSpace(fName) || fName.Length < 2)
            {
                result = false;
                reason += "First name must be at least 2 characters" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(lName) || lName.Length < 2)
            {
                result = false;
                reason += "Last name must be at least 2 characters" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(sin) || sin.Length != 9)
            {
                result = false;
                reason += "SIN must be exactly 9 characters" + Environment.NewLine;
            }
            else if (!long.TryParse(sin, out tempVal))
            {
                result = false;
                reason += "SIN must be numeric" + Environment.NewLine;
            }

            if (string.IsNullOrWhiteSpace(phone) || phone.Replace(" ", "").Length < 10)
            {
                result = false;
                reason += "Phone # must be at least 10 characters" + Environment.NewLine;
            }
            else if (!long.TryParse(phone.Replace(" ", "").Replace("-", ""), out tempVal))
            {
                result = false;
                reason += "Phone # must be numeric" + Environment.NewLine;
            }

            return result;
        }
    }
}
