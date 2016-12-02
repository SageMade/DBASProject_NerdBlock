using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer
{
    public static class Context
    {
        private static AutoDictionary<string, object> myContextObjects;

        public static AutoDictionary<string, object> Values
        {
            get { return myContextObjects; }
        }

        static Context()
        {
            myContextObjects = new AutoDictionary<string, object>();
        }

        public static object GetValue(string valueName)
        {
            return myContextObjects[valueName];
        }

        public static T GetValue<T>(string valueName)
        {
            return (T)myContextObjects[valueName];
        }

        public static bool HasValue(string valueName)
        {
            return myContextObjects.ContainsKey(valueName);
        }
        
        public static void SetValue(string valueName, object value)
        {
            myContextObjects[valueName] = value;
        }

        public static void Clear()
        {
            myContextObjects.Clear();
        }
    }
}
