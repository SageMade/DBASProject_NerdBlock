using Npgsql;

namespace NerdBlock.Sandbox
{
    /// <summary>
    /// Represents a connection to a database
    /// </summary>
    public interface IDatabase
    {
        QueryFail LastFailReason { get; set; }

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
        /// Handles preparing a new query with the given sql and query parameters
        /// </summary>
        /// <param name="sql">The source sql for this query</param>
        /// <param name="parameters">The parameters for this query</param>
        /// <returns>The prepared query</returns>
        IQuery PrepareQuery(string sql, params QueryParam[] parameters);

        /// <summary>
        /// Handles preparing a new query with the given sql and query parameters types.
        /// Parameter names will automatically be selected based on the index within the parameter
        /// array
        /// </summary>
        /// <param name="sql">The source sql for this query</param>
        /// <param name="parameters">The parameters for this query</param>
        /// <returns>The prepared query</returns>
        IQuery PrepareQuery(string sql, params QueryParamType[] parameters);

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

        /// <summary>
        /// Handles executing a query and returning the results
        /// </summary>
        /// <param name="query">The compiled query to perform</param>
        /// <param name="parameters">The parameters for the query</param>
        /// <returns>The results of the query</returns>
        IQueryResult Execute(IQuery query, params object[] parameters);
    }
}