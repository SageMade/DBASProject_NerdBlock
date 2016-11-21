using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using NpgsqlTypes;

namespace MySqlTest.Sandbox.Implementation
{
    /// <summary>
    /// Represents a postgresql implementation of the IDatabase interface
    /// </summary>
    public class PgDatabase : IDatabase
    {
        /// <summary>
        /// The underlying Npgsql database connectiong
        /// </summary>
        private NpgsqlConnection myDatabaseConnection;

        public object ConnectionObject
        {
            get { return myDatabaseConnection; }
        }

        public IQueryResult Execute(IQuery query)
        {
            NpgsqlCommand command = query.QueryObject as NpgsqlCommand;

            if (command == null)
                throw new ArgumentException("Query is not an Npgsql Command object");

            command.Connection = myDatabaseConnection;
                        
            return new PgQueryResult(new NpgsqlDataAdapter(command));
        }

        public IQueryResult Execute(string query)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, myDatabaseConnection);
            return new PgQueryResult(new NpgsqlDataAdapter(command));
        }

        public void Init(DbConnectData connectData)
        {
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Username = connectData.Username;
            builder.Password = connectData.Password;

            builder.Port = connectData.Port == -1 ? builder.Port : connectData.Port;
            builder.Host = connectData.Host;
            builder.Database = connectData.Database;

            myDatabaseConnection = new NpgsqlConnection(builder);
            myDatabaseConnection.Open();
        }
    }
}
