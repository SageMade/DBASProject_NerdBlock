using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Shared
{
    public static class Session
    {
        private static AutoDictionary<string, object> mySessionValues;

        static Session()
        {
            mySessionValues = new AutoDictionary<string, object>();
        }
    }
}
