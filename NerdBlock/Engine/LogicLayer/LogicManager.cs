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
        private static Dictionary<string, Action> myViewActions;
        private static List<BusinessRule> myRules;

        static LogicManager()
        {
            myRules = new List<BusinessRule>();
            myViewActions = new Dictionary<string, Action>();
        }

        public static void LoadRule(BusinessRule rule)
        {
            myRules.Add(rule);
        }

        public static void LoadRules(Assembly assemby = null)
        {
            assemby = assemby == null ? Assembly.GetExecutingAssembly() : assemby;

            Type[] types = assemby.GetTypes().Where( T=> T.BaseType == typeof(BusinessRule)).ToArray();

            for (int index = 0; index < types.Length; index++)
                LoadRule(Activator.CreateInstance(types[index]) as BusinessRule);
        }

        public static bool HasAction(string name)
        {
            return myViewActions.ContainsKey(name);
        }

        public static void RegisterAction(string name, Action action)
        {
            myViewActions.Add(name, action);
        }
        
        public static string TryPerformAction(string actionName)
        {
            if (!myViewActions.ContainsKey(actionName))
                return "Action not found";

            string reason = null;

            for(int index = 0; index < myRules.Count; index ++)
            {
                if (!myRules[index].CanPerform(actionName, ref reason))
                    return reason;
            }

            myViewActions[actionName].Invoke();

            return reason;
        }
    }
}
