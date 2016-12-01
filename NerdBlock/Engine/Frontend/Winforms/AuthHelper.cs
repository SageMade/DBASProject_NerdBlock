using System;
using NerdBlock.Engine.Backend.Models;
using System.Collections.Generic;
using NerdBlock.Engine.Backend;

namespace NerdBlock.Engine.Frontend.Winforms
{
    internal static class AuthHelper
    {
        private static Dictionary<EmployeeRole, List<string>> myRoleMapping;

        static AuthHelper()
        {
            myRoleMapping = new Dictionary<EmployeeRole, List<string>>();

            EmployeeRole[] roles = DataAccess.SelectAll<EmployeeRole>();

            //Type[] authedViews = 
        }
                
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