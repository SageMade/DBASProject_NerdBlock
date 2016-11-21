using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlTest.Sandbox.Implementation
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
            get { return myTable.Rows.Count; }
        }
        /// <summary>
        /// Gets the index of the current row in the data results
        /// </summary>
        public int CurrentRow
        {
            get { return myRowIndex; }
        }

        /// <summary>
        /// Creates a new query result from the given data adapter
        /// </summary>
        /// <param name="adapter">The data adapter to create the result set from</param>
        public PgQueryResult(NpgsqlDataAdapter adapter)
        {
            myDataAdapter = adapter;
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet);
            myTable = myDataSet.Tables[0];
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
