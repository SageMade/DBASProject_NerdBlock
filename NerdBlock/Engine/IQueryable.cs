using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox
{
    /// <summary>
    /// Represents an object that can be queried from the database. This does not necessarily support C.R.U.D operations, but
    /// can be used to get data from arbitrary queries
    /// </summary>
    /// <typeparam name="ChildType">The type of the implementor</typeparam>
    public interface IQueryable<ChildType>
    {
        /// <summary>
        /// Queries the database and returns the results
        /// </summary>
        /// <param name="database">The database to query against</param>
        /// <returns>The results of the query as a collection of objects</returns>
        ChildType[] Execute();

        /// <summary>
        /// Queries the database and returns the results
        /// </summary>
        /// <param name="database">The database to query against</param>
        /// <param name="search">The object to use as a search term</param>
        /// <returns>The results of the query as a collection of objects</returns>
        ChildType[] Query(ChildType search);
    }
}
