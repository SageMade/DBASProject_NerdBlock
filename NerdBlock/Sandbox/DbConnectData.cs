namespace NerdBlock.Sandbox
{
    /// <summary>
    /// Represents the conenction information to use when connecting to a database
    /// resource
    /// </summary>
    public struct DbConnectData
    {
        /// <summary>
        /// The username to authenticate with
        /// </summary>
        public string Username;
        /// <summary>
        /// The password associated with <i>Username</i>
        /// </summary>
        public string Password;
        /// <summary>
        /// The TCP/IP port to connect to
        /// </summary>
        public int Port;
        /// <summary>
        /// The location to connect to
        /// </summary>
        public string Host;
        /// <summary>
        /// The database to connect to
        /// </summary>
        public string Database;
    }
}