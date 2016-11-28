using System.IO;

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

        public static DbConnectData FromFile(string filename)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException();

            TextReader reader = File.OpenText(filename);
            DbConnectData result = new DbConnectData();

            string line = reader.ReadLine();

            do
            {
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

                line = reader.ReadLine();
            }
            while (line != null);

            return result;
        }
    }
}