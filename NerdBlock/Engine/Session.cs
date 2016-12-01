using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine
{
    public static class Session
    {
        private static AutoDictionary<string, object> mySessionValues;

        public static AutoDictionary<string, object> Values
        {
            get { return mySessionValues; }
        }

        static Session()
        {
            mySessionValues = new AutoDictionary<string, object>();
        }

        public static T Get<T>(string name)
        {
            return mySessionValues.Get<T>(name);
        }

        public static void Set<T>(string name, T value)
        {
            mySessionValues[name] = value;
        }
    }
}
