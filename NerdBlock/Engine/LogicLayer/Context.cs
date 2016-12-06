namespace NerdBlock.Engine.LogicLayer
{
    /// <summary>
    /// Represents the current state of the application. This can be thought of as a short-term session
    /// </summary>
    /*
    public static class Context
    {
        /// <summary>
        /// Stores the colelction of objects
        /// </summary>
        private static AutoDictionary<string, object> myContextObjects;

        /// <summary>
        /// Get the unerlying auto-dictionary for shorthand access
        /// </summary>
        public static AutoDictionary<string, object> Values
        {
            get { return myContextObjects; }
        }

        /// <summary>
        /// Static constructor for context
        /// </summary>
        static Context()
        {
            // Build the autodictionary
            myContextObjects = new AutoDictionary<string, object>();
        }

        /// <summary>
        /// Gets a value from the context with the given name
        /// </summary>
        /// <param name="valueName">The name of the value to get</param>
        /// <returns>The object loaded from the context</returns>
        public static object GetValue(string valueName)
        {
            return myContextObjects[valueName];
        }

        /// <summary>
        /// Gets a value from the context with the given name
        /// </summary>
        /// <param name="valueName">The name of the value to get</param>
        /// <returns>The object loaded from the context</returns>
        public static T GetValue<T>(string valueName)
        {
            return (T)myContextObjects[valueName];
        }

        /// <summary>
        /// Checks to see if the context has a value for a given name
        /// </summary>
        /// <param name="valueName">The name of the value to check for</param>
        /// <returns>True if there is an element declared, false if otherwise</returns>
        public static bool HasValue(string valueName)
        {
            return myContextObjects.ContainsKey(valueName);
        }
        
        /// <summary>
        /// Sets a value on the context
        /// </summary>
        /// <param name="valueName">The name of the value to set</param>
        /// <param name="value">The value to put in the context</param>
        public static void SetValue(string valueName, object value)
        {
            myContextObjects[valueName] = value;
        }

        /// <summary>
        /// Clears the context of all values
        /// </summary>
        public static void Clear()
        {
            myContextObjects.Clear();
        }
    }
    */
}
