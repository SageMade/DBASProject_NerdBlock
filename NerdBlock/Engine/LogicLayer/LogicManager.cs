using NerdBlock.Engine.Frontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NerdBlock.Engine.LogicLayer
{
    /// <summary>
    /// The main entry point for the business logic
    /// </summary>
    public static class LogicManager
    {
        /// <summary>
        /// Stores references to the action containers so they don't get cleaned up by the GC
        /// </summary>
        private static List<object> myActionContainers;
        /// <summary>
        /// Stores the dictionary of actions that can be performed 
        /// </summary>
        private static Dictionary<string, Action> myViewActions;
        /// <summary>
        /// Stores the list of business rules that allow or dissallow actions to be invoked
        /// </summary>
        private static List<BusinessRule> myRules;

        /// <summary>
        /// Static constructor for Logic Manager
        /// </summary>
        static LogicManager()
        {
            // Build the collections
            myActionContainers = new List<object>();
            myRules = new List<BusinessRule>();
            myViewActions = new Dictionary<string, Action>();
        }
        
        /// <summary>
        /// Loads a business rule into the logic layer
        /// </summary>
        /// <param name="rule">The rule to load into the logic layer</param>
        public static void LoadRule(BusinessRule rule)
        {
            myRules.Add(rule);
        }

        /// <summary>
        /// Loads all business rules from the given assembly
        /// </summary>
        /// <param name="assembly">The assembly to use, or null to use the executing assembly</param>
        public static void LoadRules(Assembly assembly = null)
        {
            // Get a vlid assembly
            assembly = assembly == null ? Assembly.GetExecutingAssembly() : assembly;

            // Get any type that extends the businessrule class
            Type[] types = assembly.GetTypes().Where( T=> T.BaseType == typeof(BusinessRule)).ToArray();

            // Create an instance for each type
            for (int index = 0; index < types.Length; index++)
                LoadRule(Activator.CreateInstance(types[index]) as BusinessRule);
        }
         
        /// <summary>
        /// Loads all business actions in an assembly
        /// </summary>
        /// <param name="assembly">The assembly to use, or null to use the executing assembly</param>
        public static void LoadActions(Assembly assembly = null)
        {
            // Get a vlid assembly
            assembly = assembly == null ? Assembly.GetExecutingAssembly() : assembly;

            // Get any type that has the action container attribute
            Type[] types = assembly.GetTypes().Where(T => T.GetCustomAttribute<BusinessActionContainer>() != null).ToArray();

            // Iterate over each type
            for (int index = 0; index < types.Length; index++)
            {
                // Make an instance of the object and store a reference so it is not garbage collected
                object o = Activator.CreateInstance(types[index]);
                myActionContainers.Add(o);

                // Get the methods that are marked as a business action
                MethodInfo[] methods = types[index].GetMethods().Where(M => M.GetCustomAttribute<BusinessAction>() != null && M.GetParameters().Length == 0).ToArray();

                // Iterate over all methods
                for(int mIndex = 0; mIndex < methods.Length; mIndex ++)
                {
                    // Get the method and store the rule
                    MethodInfo mi = methods[mIndex];
                    BusinessAction rule = methods[mIndex].GetCustomAttribute<BusinessAction>();
                    myViewActions.Add(rule.Name, () => mi.Invoke(o, null));
                }
            }
        }

        /// <summary>
        /// Checks to see if an action has been registered with the logic layer
        /// </summary>
        /// <param name="name">The name of the action to search for</param>
        /// <returns>True if an action has been registered with that name, false if otherwise</returns>
        public static bool HasAction(string name)
        {
            return myViewActions.ContainsKey(name);
        }

        /// <summary>
        /// Registers an action with the logic layer
        /// </summary>
        /// <param name="name">The name to register the action under</param>
        /// <param name="action">The action to register</param>
        public static void RegisterAction(string name, Action action)
        {
            myViewActions.Add(name, action);
        }

        /// <summary>
        /// Attempts to perform an action
        /// </summary>
        /// <param name="actionName">The name of the action to attempt</param>
        /// <param name="msg">The message retuned from the action, or the reason that the action cannot be performed</param>
        /// <returns>True if the action was performed, false if not</returns>
        public static bool TryPerformAction(string actionName, out string msg)
        {
            // If the action is not found, we can end here
            if (!myViewActions.ContainsKey(actionName))
            {
                msg = "Action not found";
                return false;
            }
            else if (Auth.HasAccess(actionName))
            {
                // Make a temp variable for the reason and our success
                string reason = "";
                bool success = true;

                // Iterate over all rules
                for (int index = 0; index < myRules.Count; index++)
                {
                    // Check if we can perform the action. If not, mark it as failed
                    if (!myRules[index].CanPerform(actionName, ref reason))
                        success = false;
                }

                // If we are OK, invoke the action
                if (success)
                {
                    myViewActions[actionName].Invoke();
                    msg = null;
                }
                // Otherwise update the message
                else
                    msg = reason;

                // Return whether we were sucsessfull or not
                return success;
            }
            else
            {
                msg = "Authorization failed";
                return false;
            }
        }

        public static void TryPerformAction(string actionName)
        {
            string msg = "";

            if (!TryPerformAction(actionName, out msg))
                ViewManager.ShowFlash(msg, FlashMessageType.Bad);
        }
    }
}
