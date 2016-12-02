using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend
{
    /// <summary>
    /// Represents a specific reason that a query has failed
    /// </summary>
    public enum QueryFailReason
    {
        /// <summary>
        /// An item with the same primary key was found in the database
        /// </summary>
        DuplicateKeyError,
        /// <summary>
        /// An item was not found in the database
        /// </summary>
        NotFound,

    }
}
