using System;
using System.Collections.Generic;

namespace NerdBlock.Engine
{
    /// <summary>
    /// Represents a dictionary that will automagically add a default element if the key does not exist
    /// </summary>
    /// <typeparam name="Key">The type to use for keys</typeparam>
    /// <typeparam name="Value">The type to use for values</typeparam>
    public class AutoDictionary<Key, Value>
    {
        /// <summary>
        /// Represents the internal dictionary used
        /// </summary>
        private Dictionary<Key, Value> myInternalCollection;

        public Value this[Key key]
        {
            get
            {
                if (!myInternalCollection.ContainsKey(key))
                    myInternalCollection.Add(key, default(Value));

                return myInternalCollection[key];
            }
            set
            {
                if (myInternalCollection.ContainsKey(key))
                    myInternalCollection[key] = value;
                else
                    myInternalCollection.Add(key, value);
            }
        }
        
        public Dictionary<Key, Value>.ValueCollection Values
        {
            get { return myInternalCollection.Values; }
        }
        public Dictionary<Key, Value>.KeyCollection Keys
        {
            get { return myInternalCollection.Keys; }
        }

        public AutoDictionary()
        {
            myInternalCollection = new Dictionary<Key, Value>();
        }

        public bool ContainsKey(Key key)
        {
            return myInternalCollection.ContainsKey(key);
        }

        public bool ContainsValue(Value value)
        {
            return myInternalCollection.ContainsValue(value);
        }

        public void Clear()
        {
            myInternalCollection.Clear();
        }

        public T Get<T>(Key name)
        {
            object result = this[name];

            if (result == null)
                return default(T);
            else
            {
                if (typeof(T).IsAssignableFrom(result.GetType()))
                    return (T)result;
                else
                    return default(T);
            }
        }
    }
}