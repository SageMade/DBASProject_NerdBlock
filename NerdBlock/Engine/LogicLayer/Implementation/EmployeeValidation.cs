using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer.Implementation
{
    public class EmployeeValidation : BusinessRule
    {
        public const string ACTION_NAME = "insert_employee";

        public override bool CanPerform(string actionName, ref string reason)
        {
            if (actionName.Equals(ACTION_NAME))
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
            return true;
        }
    }
}
