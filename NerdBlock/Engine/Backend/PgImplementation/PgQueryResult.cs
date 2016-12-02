using Npgsql;
using System.Data;

namespace NerdBlock.Engine.Backend.PgImplementation
{
    /// <summary>
    /// Represents the results of a postgresql query
    /// </summary>
    public class PgQueryResult : IQueryResult
    {
        private NpgsqlDataAdapter myDataAdapter;
        private DataSet myDataSet;
        private DataTable myTable;

        private int myRowIndex = 0;
        private int myNumRows;

        /// <summary>
        /// Gets the data row at the current pointer
        /// </summary>
        public DataRow Row
        {
            get
            {
                if (myTable.Rows.Count > 0)
                    return myTable.Rows[myRowIndex];
                else
                    return null;
            }
        }
        /// <summary>
        /// Gets the number of results from this query
        /// </summary>
        public int NumRows
        {
            get { return myNumRows; }
        }
        /// <summary>
        /// Gets the index of the current row in the data results
        /// </summary>
        public int CurrentRow
        {
            get { return myRowIndex; }
        }
        /// <summary>
        /// Gets whether or not the query has failed
        /// </summary>
        public bool HasFailed
        {
            get { return myNumRows == -1; }
        }
        /// <summary>
        /// Gets whether this query result still has an available row
        /// </summary>
        /// <returns>True if there is another row that we can traverse to</returns>
        public bool HasRow
        {
            get { return myRowIndex < myNumRows; }
        }
        /// <summary>
        /// Gets this query result as a data set
        /// </summary>
        public DataSet Source
        {
            get { return myDataSet; }
        }

        /// <summary>
        /// Creates a new query result from the given data adapter
        /// </summary>
        /// <param name="command">The command to create the result set from</param>
        /// <param name="isNonQuery">True if the command is not a query, such as a insert, update, or delete</param>
        public PgQueryResult(NpgsqlCommand command, bool isSelect)
        {
            try
            {
                // If this is a statement, we execute as a non-query
                if (!isSelect)
                {
                    myNumRows = command.ExecuteNonQuery();
                }
                else
                {
                    // If this is a select statement
                    myDataAdapter = new NpgsqlDataAdapter(command);
                    myDataSet = new DataSet();
                    myDataAdapter.Fill(myDataSet);
                    myTable = myDataSet.Tables[0];
                    myNumRows = myTable.Rows.Count;
                }
            }
            catch (PostgresException e)
            {
                myNumRows = -1;
                DataAccess.Database.LastFailReason = new QueryFail()
                {
                    Message = e.Message,
                    Exception = e,
                    Reason = (QueryFailReason)e.ErrorCode
                };
                Logger.Log(LogLevel.Warn, e.MessageText);
            }
        }

        /// <summary>
        /// Moves to the next row in the result set
        /// </summary>
        /// <returns>True if we moved to the next element, false if otherwise</returns>
        public bool MoveNext()
        {
            if (myRowIndex < myTable.Rows.Count - 1)
            {
                myRowIndex++;
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Moves to the previous row in the result set
        /// </summary>
        /// <returns>True if we moved to the previous element, false if otherwise</returns>
        public bool MovePrev()
        {
            if (myRowIndex > 0)
            {
                myRowIndex--;
                return true;
            }
            else
                return false;
        }
    }
}
