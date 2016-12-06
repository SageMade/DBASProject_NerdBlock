using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NerdBlock.Engine.LogicLayer.Implementation
{
    public class NerdAuth : IAuthImplementation
    {
        private AutoDictionary<EmployeeRole, List<string>> myAuths;
        private List<string> myNullAuths;
        
        public object User
        {
            get; set;
        }

        public NerdAuth()
        {
            myAuths = new AutoDictionary<EmployeeRole, List<string>>();
            myNullAuths = new List<string>();

            EmployeeRole[] roles = DataAccess.SelectAll<EmployeeRole>();
            for (int index = 0; index < roles.Length; index++)
                myAuths[roles[index]] = new List<string>();

            // Get the assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Get any type that has the action container attribute
            Type[] types = assembly.GetTypes().Where(T => T.GetCustomAttribute<BusinessActionContainer>() != null).ToArray();

            // Iterate over each type
            for (int index = 0; index < types.Length; index++)
            {
                // Get the methods that are marked as a business action
                MethodInfo[] methods = types[index].GetMethods().Where(M => M.GetCustomAttribute<BusinessAction>() != null && M.GetParameters().Length == 0).ToArray();

                // Iterate over all methods
                for (int mIndex = 0; mIndex < methods.Length; mIndex++)
                {
                    // Get the methods
                    MethodInfo mi = methods[mIndex];
                    AuthAttrib authRule = methods[mIndex].GetCustomAttribute<AuthAttrib>();
                    BusinessAction rule = methods[mIndex].GetCustomAttribute<BusinessAction>();

                    // As long as we have both an action attrib and an auth attrib
                    if (authRule != null && rule != null)
                    {
                        // Add the action to our null auths if applicable
                        if (authRule.AllowNull)
                            myNullAuths.Add(rule.Name);

                        // Iterate over each role access in the attribute
                        for(int rIndex = 0; rIndex < authRule.RoleNames.Length; rIndex ++)
                        {
                            // If the role name is an asterics, we grant to all
                            if (authRule.RoleNames[rIndex] == "*")
                            {
                                // Iterate over all roles and grant access to the action
                                for(int riIndex = 0; riIndex < roles.Length; riIndex ++)
                                    myAuths[roles[riIndex]].Add(rule.Name);

                                // Break out of the loop
                                break;
                            }
                            // If the role name is anything else, handle it!
                            else
                            {
                                // Try to find a role by that name
                                EmployeeRole role = roles.FirstOrDefault((X) => X.Name.ToLower() == authRule.RoleNames[rIndex].ToLower());

                                // If we found a role, give it permission for this action
                                if (role != null)
                                    myAuths[role].Add(rule.Name);
                            }
                        }
                    }
                }
            }
        }

        public bool HasAccess(string actionName)
        {
            if (User is Employee)
            {
                EmployeeRole role = ((Employee)User).Role;
                return myAuths[role].Contains(actionName);                
            }
            else
                return myNullAuths.Contains(actionName);
        }

        public bool TryAction(string actionName, out string message)
        {
            if (HasAccess(actionName))
            {
                return LogicManager.TryPerformAction(actionName, out message);
            }
            else
            {
                message = "Authorization failed";
                return false;
            }
        }
    }
}
