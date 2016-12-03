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
            __GetRoleMapping(role, ref viewName).Add(viewName);
        }

        /// <summary>
        /// Denies a role access to a view
        /// </summary>
        /// <param name="role">The role to grant access to</param>
        /// <param name="viewName">The name of the role to allow access</param>
        public static void Disallow(EmployeeRole role, string viewName)
        {
            List<string> lst = __GetRoleMapping(role, ref viewName);

            if (lst.Contains(viewName))
                lst.Remove(viewName);
        }

        /// <summary>
        /// Checks to see if a role has access to a view
        /// </summary>
        /// <param name="role">The role to check</param>
        /// <param name="viewName">The name of the view to check access for</param>
        /// <returns>True if the role has access, false if not</returns>
        public static bool HasAccess(this EmployeeRole role, string viewName)
        {
            return __GetRoleMapping(role, ref viewName).Contains(viewName);
        }

        /// <summary>
        /// Handles getting the list for a role map, ensuring it exists in the 
        /// </summary>
        /// <param name="role">The role to get the collection for</param>
        /// <param name="viewName">The name of the view you would like to operate on</param>
        /// <returns></returns>
        private static List<string> __GetRoleMapping(EmployeeRole role, ref string viewName)
        {
            viewName = viewName.ToLower();

            if (!myRoleMapping.ContainsKey(role))
                myRoleMapping.Add(role, new List<string>());

            return myRoleMapping[role];
        }
    }
}