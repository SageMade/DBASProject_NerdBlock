using NerdBlock.Engine.Backend.Models;
using System.Collections.Generic;
using NerdBlock.Engine.Backend;

namespace NerdBlock.Engine.Frontend.Winforms
{
    /// <summary>
    /// A helper class for authorization
    /// </summary>
    internal static class AuthHelper
    {
        private static Dictionary<EmployeeRole, List<string>> myRoleMapping;

        /// <summary>
        /// Static constructor, creates the internal dictionary
        /// </summary>
        static AuthHelper()
        {
            myRoleMapping = new Dictionary<EmployeeRole, List<string>>();

            EmployeeRole[] roles = DataAccess.SelectAll<EmployeeRole>();

            //Type[] authedViews = 
        }
         
        /// <summary>
        /// Grants a role access to a view
        /// </summary>
        /// <param name="role">The role to grant access to</param>
        /// <param name="viewName">The name of the role to allow access</param>
        public static void Allow(EmployeeRole role, string viewName)
        {

            viewName = viewName.ToLower();

            if (!myRoleMapping.ContainsKey(role))
                myRoleMapping.Add(role, new List<string>());

            myRoleMapping[role].Add(viewName);
        }

        public static void Disallow(EmployeeRole role, string viewName)
        {
            viewName = viewName.ToLower();

            if (!myRoleMapping.ContainsKey(role))
                myRoleMapping.Add(role, new List<string>());

            if (myRoleMapping[role].Contains(viewName))
                myRoleMapping[role].Remove(viewName);
        }

        public static bool HasAccess(this EmployeeRole role, string viewName)
        {
            viewName = viewName.ToLower();

            if (!myRoleMapping.ContainsKey(role))
                myRoleMapping.Add(role, new List<string>());

            return myRoleMapping[role].Contains(viewName);
        }
    }
}