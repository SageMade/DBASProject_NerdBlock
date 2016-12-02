using System.IO;

namespace NerdBlock.Engine.Backend
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

        /// <summary>
        /// Loads a DbConnectData from an external file
        /// </summary>
        /// <param name="filename">The filename to load from</param>
        /// <returns>The Connection data loaded from the file</returns>
        public static DbConnectData FromFile(string filename)
        {
            // If the file does not exist, throw an exception
            if (!File.Exists(filename))
                throw new FileNotFoundException();

            // Open the text reader and make the result
            TextReader reader = File.OpenText(filename);
            DbConnectData result = new DbConnectData();

            // Get the line from the file
            string line = reader.ReadLine();

            // Try to parse a line as long as we have one
            do
            {
                // Parse out the line
                if (line.StartsWith("Host: "))
                    result.Host = line.Replace("Host: ", "");
                else if (line.StartsWith("Database: "))
                    result.Database = line.Replace("Database: ", "");
                else if (line.StartsWith("Username: "))
                    result.Username = line.Replace("Username: ", "");
                else if (line.StartsWith("Password: "))
                    result.Password = line.Replace("Password: ", "");
                else if (line.StartsWith("Port: "))
                    result.Port = int.Parse(line.Replace("Port: ", "").Trim());

                // Move to next line
                line = reader.ReadLine();
            }
            while (line != null);

            // return the result
            return result;
        }
    }
}