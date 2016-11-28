using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer
{
    public static class LogicManager
    {
        private static List<object> myActionContainers;
        private static Dictionary<string, Action> myViewActions;
        private static List<BusinessRule> myRules;

        static LogicManager()
        {
            myActionContainers = new List<object>();
            myRules = new List<BusinessRule>();
            myViewActions = new Dictionary<string, Action>();
        }

        public static void LoadRule(BusinessRule rule)
        {
            myRules.Add(rule);
        }

        public static void LoadRules(Assembly assembly = null)
        {
            assembly = assembly == null ? Assembly.GetExecutingAssembly() : assembly;

            Type[] types = assembly.GetTypes().Where( T=> T.BaseType == typeof(BusinessRule)).ToArray();

            for (int index = 0; index < types.Length; index++)
                LoadRule(Activator.CreateInstance(types[index]) as BusinessRule);
        }
         
        public static void LoadActions(Assembly assembly = null)
        {
            assembly = assembly == null ? Assembly.GetExecutingAssembly() : assembly;

            Type[] types = assembly.GetTypes().Where(T => T.GetCustomAttribute<BusinessActionContainer>() != null).ToArray();

            for (int index = 0; index < types.Length; index++)
            {
                object o = Activator.CreateInstance(types[index]);
                myActionContainers.Add(o);

                MethodInfo[] methods = types[index].GetMethods().Where(M => M.GetCustomAttribute<BusinessAction>() != null && M.GetParameters().Length == 0).ToArray();

                for(int mIndex = 0; mIndex < methods.Length; mIndex ++)
                {
                    MethodInfo mi = methods[mIndex];
                    BusinessAction rule = methods[mIndex].GetCustomAttribute<BusinessAction>();
                    myViewActions.Add(rule.Name, () => mi.Invoke(o, null));
                }
            }
        }

        public static bool HasAction(string name)
        {
            return myViewActions.ContainsKey(name);
        }

        public static void RegisterAction(string name, Action action)
        {
            myViewActions.Add(name, action);
        }

        public static bool TryPerformAction(string actionName, out string msg)
        {
            if (!myViewActions.ContainsKey(actionName))
            {
                msg = "Action not found";
                return false;
            }

            string reason = "";
            bool success = true;

            for (int index = 0; index < myRules.Count; index++)
            {
                if (!myRules[index].CanPerform(actionName, ref reason))
                    success = false;
            }

            if (success)
            {
                myViewActions[actionName].Invoke();
                msg = null;
            }
            else
                msg = reason;

            return success;
        }
    }
}
