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

        /// <summary>
        /// Gets the vlaue for the given key, if the key is not found, the default value of <i>Value</i> will be returned
        /// </summary>
        /// <param name="key">The key to use as a lookup</param>
        /// <returns>The value with the given name, or null if the key does not exist</returns>
        public Value this[Key key]
        {
            get
            {
                if (!myInternalCollection.ContainsKey(key))
                    return default(Value);

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
        
        /// <summary>
        /// Gets the value collection for this dictionary
        /// </summary>
        public Dictionary<Key, Value>.ValueCollection Values
        {
            get { return myInternalCollection.Values; }
        }
        /// <summary>
        /// Gets the keys collection from this dictionary
        /// </summary>
        public Dictionary<Key, Value>.KeyCollection Keys
        {
            get { return myInternalCollection.Keys; }
        }

        /// <summary>
        /// Create a new auto-dictionary
        /// </summary>
        public AutoDictionary()
        {
            myInternalCollection = new Dictionary<Key, Value>();
        }

        /// <summary>
        /// Checks to see if this collection contains a given key
        /// </summary>
        /// <param name="key">The key to search for</param>
        /// <returns>True if the key exists, false if otherwise</returns>
        public bool ContainsKey(Key key)
        {
            return myInternalCollection.ContainsKey(key);
        }

        /// <summary>
        /// Checks to see if this collection contains a given value
        /// </summary>
        /// <param name="value">The value to search for</param>
        /// <returns>True if the value exists, false if otherwise</returns>
        public bool ContainsValue(Value value)
        {
            return myInternalCollection.ContainsValue(value);
        }

        /// <summary>
        /// Clears this collection of all keys and values
        /// </summary>
        public void Clear()
        {
            myInternalCollection.Clear();
        }

        /// <summary>
        /// Gets the value associated with the given key cast as a given type
        /// </summary>
        /// <typeparam name="T">The type to cast the value to</typeparam>
        /// <param name="key">The key to get the value from</param>
        /// <returns>The value cast as type <i>T</i></returns>
        public T Get<T>(Key key)
        {
            // If we can even assign T from Value
            if (typeof(T).IsAssignableFrom(typeof(Value)) || typeof(Value) == typeof(object))
            {
                // If we have a value in the collection, cast it
                if (myInternalCollection.ContainsKey(key))
                    return (T)((object)myInternalCollection[key]);
                // Otherwise just return the default T value
                else
                    return default(T);
            }
            // If we cannot even cast T from Value, we just return the default T
            else
                return default(T);
        }
    }
}