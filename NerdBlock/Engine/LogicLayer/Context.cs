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

        public static object GetObject(string valueName)
        {
            if (myContextObjects.ContainsKey(valueName))
                return myContextObjects[valueName];
            else
                return null;
        }

        public static bool HasObject(string valueName)
        {
            return myContextObjects.ContainsKey(valueName);
        }

        public static void SetObject(string valueName, object value)
        {
            if (myContextObjects.ContainsKey(valueName))
                myContextObjects[valueName] = value;
            else
                myContextObjects.Add(valueName, value);
        }
    }
}
