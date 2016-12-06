using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend
{
    public class IoMap
    {
        private AutoDictionary<string, object> myInputDictionary;
        private AutoDictionary<string, object> myOutputDictionary;

        public IoMap()
        {
            myInputDictionary = new AutoDictionary<string, object>();
            myOutputDictionary = new AutoDictionary<string, object>();
        }

        public T GetInput<T>(string name)
        {
            return myInputDictionary.Get<T>(name);
        }

        public void SetInput<T>(string name, T value)
        {
            myInputDictionary[name] = value;
        }

        public bool HasInput(string name)
        {
            return myInputDictionary.ContainsKey(name);
        }

        public bool HasInput<T>(string name)
        {
            return myInputDictionary.ContainsKey(name) && myInputDictionary[name].GetType() == typeof(T);
        }

        public T GetOutput<T>(string name)
        {
            return myOutputDictionary.Get<T>(name);
        }

        public void SetOutput<T>(string name, T value)
        {
            myOutputDictionary[name] = value;
        }

        public bool HasOutput(string name)
        {
            return myOutputDictionary.ContainsKey(name);
        }

        public bool HasOutput<T>(string name)
        {
            return myOutputDictionary.ContainsKey(name) && myOutputDictionary[name].GetType() == typeof(T);
        }

        public void Reset()
        {
            myInputDictionary.Clear();
            myOutputDictionary.Clear();
        }
    }
}
