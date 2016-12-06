using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NerdBlock.Engine.LogicLayer.Implementation
{
    /// <summary>
    /// The NerdBlock specific implementation for the IAuth engine
    /// </summary>
    public class NerdAuth : IAuthImplementation
    {
        private AutoDictionary<EmployeeRole, List<AuthEntry>> myAuths;
        private List<string> myNullAuths;
     
        /// <summary>
        /// Gets or sets the authorization uset
        /// </summary>   
        public object User
        {
            get; set;
        }

        /// <summary>
        /// Creates a new instance of the NerdBlock authorization instance
        /// </summary>
        public NerdAuth()
        {
            // Create the colelctions
            myAuths = new AutoDictionary<EmployeeRole, List<AuthEntry>>();
            myNullAuths = new List<string>();

            // Add all the employee roles as auth roles
            EmployeeRole[] roles = DataAccess.SelectAll<EmployeeRole>();
            for (int index = 0; index < roles.Length; index++)
                myAuths[roles[index]] = new List<AuthEntry>();

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

        /// <summary>
        /// Checks to see if the currently authorized user has access to an action
        /// </summary>
        /// <param name="actionName">The action name to check for access to</param>
        /// <returns>True if the employee has access to the action, false if otherwise</returns>
        public bool HasAccess(string actionName)
        {
            // If the user auth object is an employee
            if (User is Employee)
            {
                // Check the auth table for permission
                AuthEntry entry = myAuths[((Employee)User).Role].FirstOrDefault((X) => X.ActionName.Equals(actionName));
                // Return whether there was an entry, and if that entry allows us permission
                return entry != null && entry.IsAllowed;       
            }
            // If the auth object is null or another type, search the NullAuths collection
            else
                return myNullAuths.Contains(actionName);
        }

        /// <summary>
        /// Attempts an action, and returns whether it was authorized or not
        /// </summary>
        /// <param name="actionName">The name of the action to perform</param>
        /// <param name="message">The output variable to store messages from the action</param>
        /// <returns>True if the action was performed, false if otherwise</returns>
        public bool TryAction(string actionName, out string message)
        {
            // If they have access, perform the action
            if (HasAccess(actionName))
                return LogicManager.TryPerformAction(actionName, out message);
            // Otherwise fail
            else
            {
                message = "Authorization failed";
                return false;
            }
        }

        /// <summary>
        /// Represents a single entry in the authorization table
        /// </summary>
        private class AuthEntry
        {
            /// <summary>
            /// Gets or sets the action that this permission is for
            /// </summary>
            public string ActionName;
            /// <summary>
            /// Gets or sets whether the action is allowed
            /// </summary>
            public bool IsAllowed;

            /// <summary>
            /// Creates a new permission entry, with the given action name. This will set
            /// IsAllowed to true
            /// </summary>
            /// <param name="name">The name of the action that this permission applies to</param>
            public AuthEntry(string name)
            {
                ActionName = name;
                IsAllowed = true;
            }

            /// <summary>
            /// Creates a new permission entry, with the given action name and whether it is allowed
            /// </summary>
            /// <param name="name">The name of the action that this permission applies to</param>
            /// <param name="allowed">Whether the action is allowed</param>
            public AuthEntry(string name, bool allowed)
            {
                ActionName = name;
                IsAllowed = allowed;
            }

            /// <summary>
            /// Gets a semi-unique hash code for this instance
            /// </summary>
            /// <returns>A semi-unique hash code</returns>
            public override int GetHashCode()
            {
                return ActionName.GetHashCode();
            }

            /// <summary>
            /// Checks to see if this instance is equal to another object
            /// </summary>
            /// <param name="obj">The object to compare to</param>
            /// <returns>True if this=obj, false if otherwise</returns>
            public override bool Equals(object obj)
            {
                return obj is AuthEntry && (obj as AuthEntry).ActionName.Equals(ActionName);
            }

            /// <summary>
            /// Creates a string representation of this instance
            /// </summary>
            /// <returns>A string representing this instance</returns>
            public override string ToString()
            {
                return ActionName;
            }

            /// <summary>
            /// Overloads the equality operator
            /// </summary>
            /// <param name="left">The left hand operand</param>
            /// <param name="right">The right hand operand</param>
            /// <returns>True if left equals right, false if not</returns>
            public static bool operator ==(AuthEntry left, AuthEntry right)
            {
                return left.Equals(right);
            }

            /// <summary>
            /// Overloads the inequality operator
            /// </summary>
            /// <param name="left">The left hand operand</param>
            /// <param name="right">The right hand operand</param>
            /// <returns>True if left is not equal to right, false if it is</returns>
            public static bool operator !=(AuthEntry left, AuthEntry right)
            {
                return !left.Equals(right);
            }


            /// <summary>
            /// Handles implicitly casting a string to a permission entry, this
            /// will create an entry with IsAllowed set to true
            /// </summary>
            /// <param name="name">The action name that the permission applies to</param>
            public static implicit operator AuthEntry(string name)
            {
                return new AuthEntry(name);
            }
        }
    }
}
