namespace NerdBlock.Engine
{
    /// <summary>
    /// Represents a single query or statement that can be executed against a database
    /// </summary>
    public interface IQuery
    {
        /// <summary>
        /// Gets the SQL source of the query
        /// </summary>
        string SqlSource { get; }

        /// <summary>
        /// Gets whether this query actually returns results (i.e. is it a select statement)
        /// </summary>
        bool HasResults { get; }

        /// <summary>
        /// Gets a handle to the underlying database command object
        /// </summary>
        object QueryObject { get; }

        /// <summary>
        /// Gets the number of parameters in this query
        /// </summary>
        int ParameterCount { get; }

        /// <summary>
        /// Sets the parameter with the given index to the value
        /// </summary>
        /// <param name="index">The index of the parameter</param>
        /// <param name="value">The value to set the parameter to</param>
        void SetParameter(int index, object value);
    }
}