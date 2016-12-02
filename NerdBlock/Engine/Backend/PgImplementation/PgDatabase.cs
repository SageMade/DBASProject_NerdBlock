using System;
using Npgsql;
using System.Threading;

namespace NerdBlock.Engine.Backend.PgImplementation
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

        /// <summary>
        /// Gets the underlying postgres database connection
        /// </summary>
        public object ConnectionObject
        {
            get { return myDatabaseConnection; }
        }
        
        /// <summary>
        /// Gets or sets the last reason for a query failing
        /// </summary>
        public QueryFail LastFailReason
        {
            get;
            set;
        }

        /// <summary>
        /// Handles executing a query and returning the results
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>The query result from creating the query</returns>
        public IQueryResult Execute(IQuery query)
        {
            // Get the query as an NPgsql command
            NpgsqlCommand command = query.QueryObject as NpgsqlCommand;

            // If the command is null, we throw an exception
            if (command == null)
                throw new ArgumentException("Query is not an Npgsql Command object");

            // Set the command's to our connection
            command.Connection = myDatabaseConnection;
                        
            // Execute the query and return the result
            return new PgQueryResult(command, query.HasResults);
        }
        
        /// <summary>
        /// Executes a query and returns the results
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <param name="parameters">The parameters for the query</param>
        /// <returns>The query results returned from the query</returns>
        public IQueryResult Execute(IQuery query, params object[] parameters)
        {
            // Gets the query as an Npgsql command
            NpgsqlCommand command = query.QueryObject as NpgsqlCommand;

            // If the command is null, we throw an exception
            if (command == null)
                throw new ArgumentException("Query is not an Npgsql Command object");

            // Set the command's to our connection
            command.Connection = myDatabaseConnection;

            // If we have the wrong number of parameters, throw an exception
            if (parameters.Length != query.ParameterCount)
                throw new ArgumentException("Parameter count mismatch");

            // Set the parameters in the query
            for (int index = 0; index < query.ParameterCount; index++)
                query.SetParameter(index, parameters[index]);

            // Execute the query and return the result
            return new PgQueryResult(command, query.HasResults);
        }

        /// <summary>
        /// Handles executing a query and returning the results
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>The query result from creating the query</returns>
        public IQueryResult Execute(string query)
        {
            // Creates a new Npgsql command from the query string
            NpgsqlCommand command = new NpgsqlCommand(query, myDatabaseConnection);

            // Guesstimate whether the command is a query or statement
            if (query.ToLower().Contains("select"))
                return new PgQueryResult(command, true);
            else
                return new PgQueryResult(command, false);
        }

        /// <summary>
        /// Handles initializing the database conenction
        /// </summary>
        /// <param name="connectData"></param>
        public void Init(DbConnectData connectData)
        {
            // Build the connection from the connection data
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();

            builder.Username = connectData.Username;
            builder.Password = connectData.Password;
            builder.Port = connectData.Port == -1 ? builder.Port : connectData.Port;
            builder.Host = connectData.Host;
            builder.Database = connectData.Database;

            // Create and open our connection
            myDatabaseConnection = new NpgsqlConnection(builder);
            myDatabaseConnection.Open();

            // We haven't failed yet! :D
            LastFailReason = null;

            // Sleep until the connection has been opened
            while ((ConnectionObject as NpgsqlConnection).State != System.Data.ConnectionState.Open)
                Thread.Sleep(1);
        }

        /// <summary>
        /// Handles preparing a query with this database
        /// </summary>
        /// <param name="sql">The source SQL for the query</param>
        /// <param name="parameters">The input parameter types</param>
        /// <returns>The IQuery created from the database</returns>
        public IQuery PrepareQuery(string sql, params QueryParamType[] parameters)
        {
            // Create the parameter array
            NpgsqlParameter[] npsqlParameters = new NpgsqlParameter[parameters.Length];

            // Create an Npgsql parameter for each type
            for (int index = 0; index < parameters.Length; index ++)
                npsqlParameters[index] = new NpgsqlParameter((index + 1).ToString(), parameters[index].ToNpgsql());
            
            // Create and return the query
            return new PgQuery(DataAccess.Database, sql, sql.ToLower().Contains("select"), npsqlParameters);
        }

        /// <summary>
        /// Handles preparing a query with this database
        /// </summary>
        /// <param name="sql">The source SQL for the query</param>
        /// <param name="parameters">The query input parameters</param>
        /// <returns>The IQuery created from the database</returns>
        public IQuery PrepareQuery(string sql, params QueryParam[] parameters)
        {
            // Create the parameter array
            NpgsqlParameter[] npsqlParameters = new NpgsqlParameter[parameters.Length];

            // Create an Npgsql parameter for each query parameter
            for (int index = 0; index < parameters.Length; index++)
                npsqlParameters[index] = new NpgsqlParameter(parameters[index].Name, parameters[index].Type.ToNpgsql());

            // Create and return the query
            return new PgQuery(DataAccess.Database, sql, sql.ToLower().Contains("select"), npsqlParameters);
        }

        /// <summary>
        /// Prepares a query that does not accept any parameters
        /// </summary>
        /// <param name="sql">The source SQL for the query</param>
        /// <returns></returns>
        public IQuery PrepareQuery(string sql)
        {
            // Create and return the query
            return new PgQuery(DataAccess.Database, sql, sql.ToLower().Contains("select"));
        }
    }
}
