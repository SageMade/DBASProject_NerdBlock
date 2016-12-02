using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using System.Text.RegularExpressions;

namespace NerdBlock.Engine.Backend.PgImplementation
{
    /// <summary>
    /// Represents the Postgres implementation of the IQuery interface
    /// </summary>
    public class PgQuery : IQuery
    {
        private NpgsqlCommand myCommand;
        private bool isSelect;

        /// <summary>
        /// Gets the underlying query object
        /// </summary>
        public object QueryObject
        {
            get { return myCommand; }
        }
        /// <summary>
        /// Gets the SQL source for the query
        /// </summary>
        public string SqlSource
        {
            get { return myCommand.CommandText; }
        }
        /// <summary>
        /// Gets the parameter count for the query
        /// </summary>
        public int ParameterCount
        {
            get { return myCommand.Parameters.Count; }
        }
        /// <summary>
        /// Gets whether or not this query returns results. This will return true for selects
        /// and false for statements
        /// </summary>
        public bool HasResults
        {
            get { return isSelect; }
        }

        /// <summary>
        /// Creates a new postgres query connection
        /// </summary>
        /// <param name="database">The database to create the query for</param>
        /// <param name="query">The source string for the query</param>
        /// <param name="hasReturn">True if this query returns results, false if it's a statement</param>
        public PgQuery(IDatabase database, string query, bool hasReturn)
        {
            myCommand = new NpgsqlCommand(query, database.ConnectionObject as NpgsqlConnection);
            myCommand.Prepare();
            isSelect = hasReturn;
        }

        /// <summary>
        /// Creates a new postgres query connection from a format string
        /// </summary>
        /// <param name="database">The database to create the query for</param>
        /// <param name="query">The format source string for the query</param>
        /// <param name="hasReturn">True if this query returns results, false if it's a statement</param>
        /// <param name="commandParams">The parameters to format into the query source</param>
        public PgQuery(IDatabase database, string query, bool hasReturn, params object[] commandParams)
        {
            query = string.Format(query, commandParams);
            myCommand = new NpgsqlCommand(query, database.ConnectionObject as NpgsqlConnection);
            
            myCommand.Prepare();
            isSelect = hasReturn;
        }

        /// <summary>
        /// Creates a new postgres query connection from a format string
        /// </summary>
        /// <param name="database">The database to create the query for</param>
        /// <param name="query">The format source string for the query</param>
        /// <param name="hasReturn">True if this query returns results, false if it's a statement</param>
        /// <param name="commandParams">The parameters to format into the query source</param>
        public PgQuery(IDatabase database, string query, bool hasReturn, NpgsqlParameter[] sqlParams, params object[] commandParams)
        {
            query = string.Format(query, commandParams);
            myCommand = new NpgsqlCommand(query, database.ConnectionObject as NpgsqlConnection);
            myCommand.Parameters.AddRange(sqlParams);
            myCommand.Prepare();
            isSelect = hasReturn;
        }
        
        /// <summary>
        /// Creates a new parameterless query with the given sql        
        /// </summary>
        /// <param name="query">The SQL source for the query</param>
        public PgQuery(string query)
        {
            myCommand = new NpgsqlCommand(query);
        }

        /// <summary>
        /// Creates a new parameterless query with the given format string and parameters      
        /// </summary>
        /// <param name="query">The format source for the query</param>
        /// <param name="commandParams">The format parameters for the query source</param>
        public PgQuery(string query, params object[] commandParams)
        {
            myCommand = new NpgsqlCommand(string.Format(query, commandParams));
        }

        /// <summary>
        /// Sets the parameter at the given index to the value
        /// </summary>
        /// <param name="index">The index of the parameter</param>
        /// <param name="value">The value to set the parameter to</param>
        public void SetParameter(int index, object value)
        {
            myCommand.Parameters[index].Value = value;
        }
    }
}
