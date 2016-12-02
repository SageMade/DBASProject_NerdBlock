using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend
{
    /// <summary>
    /// Represents the reason that a query or statement has failed
    /// </summary>
    public class QueryFail
    {
        /// <summary>
        /// Gets or sets the specific reason
        /// </summary>
        public QueryFailReason Reason { get; set; }
        /// <summary>
        /// Gets or sets the underlying exception
        /// </summary>
        public Exception Exception { get; set; }
        /// <summary>
        /// Gets or sets the message for why this query failed
        /// </summary>
        public string Message { get; set; }
    }
}
