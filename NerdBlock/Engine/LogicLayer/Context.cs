using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer
{
    public static class Context
    {
        private static Dictionary<string, object> myContextObjects;

        static Context()
        {
            myContextObjects = new Dictionary<string, object>();
        }

        public static object GetValue(string valueName)
        {
            if (myContextObjects.ContainsKey(valueName))
                return myContextObjects[valueName];
            else
                return null;
        }

        public static T GetValue<T>(string valueName)
        {
            if (myContextObjects.ContainsKey(valueName))
                return (T)myContextObjects[valueName];
            else
                return default(T);
        }

        public static bool HasValue(string valueName)
        {
            return myContextObjects.ContainsKey(valueName);
        }

        public static void Clear()
        {
            myContextObjects.Clear();
        }

        public static void SetValue(string valueName, object value)
        {
            if (myContextObjects.ContainsKey(valueName))
                myContextObjects[valueName] = value;
            else
                myContextObjects.Add(valueName, value);
        }
    }
}
