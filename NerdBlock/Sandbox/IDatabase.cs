using Npgsql;

namespace MySqlTest.Sandbox
{
    /// <summary>
    /// Represents a connection to a database
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Gets the underlying database connection object
        /// </summary>
        object ConnectionObject { get; }

        /// <summary>
        /// Initializes the connection to the database
        /// </summary>
        /// <param name="connectData">The connection information for the database</param>
        void Init(DbConnectData connectData);

        /// <summary>
        /// Handles executing a query and returning the results
        /// </summary>
        /// <param name="query">The raw SQL query to perform</param>
        /// <returns>The results of the query</returns>
        IQueryResult Execute(string query);

        /// <summary>
        /// Handles executing a query and returning the results
        /// </summary>
        /// <param name="query">The compiled query to perform</param>
        /// <returns>The results of the query</returns>
        IQueryResult Execute(IQuery query);
    }
}