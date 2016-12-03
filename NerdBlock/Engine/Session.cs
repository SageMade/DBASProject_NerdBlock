namespace NerdBlock.Engine
{
    /// <summary>
    /// Stores application-level values, similar to a web Session or Cookie collection
    /// </summary>
    public static class Session
    {
        /// <summary>
        /// Stores the values
        /// </summary>
        private static AutoDictionary<string, object> mySessionValues;

        /// <summary>
        /// Get the values collection in the session
        /// </summary>
        public static AutoDictionary<string, object> Values
        {
            get { return mySessionValues; }
        }

        /// <summary>
        /// Static constructor for the session
        /// </summary>
        static Session()
        {
            mySessionValues = new AutoDictionary<string, object>();
        }

        /// <summary>
        /// Gets the value associated with the given key cast as a given type
        /// </summary>
        /// <typeparam name="T">The type to cast the value to</typeparam>
        /// <param name="name">The name of the value to get</param>
        /// <returns>The value cast as type <i>T</i></returns>
        public static T Get<T>(string name)
        {
            return mySessionValues.Get<T>(name);
        }

        /// <summary>
        /// Sets a value in the session with the given name and value
        /// </summary>
        /// <typeparam name="T">The type of the value to insert</typeparam>
        /// <param name="name">The name of the value to set</param>
        /// <param name="value">The value to assign</param>
        public static void Set<T>(string name, T value)
        {
            mySessionValues[name] = value;
        }
    }
}
