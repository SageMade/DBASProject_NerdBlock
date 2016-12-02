using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Backend
{
    /// <summary>
    /// Represents a single parameter into a query
    /// </summary>
    public struct QueryParam
    {
        /// <summary>
        /// Gets or sets the naem of the parameter
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The query parameter type for this parameter
        /// </summary>
        public QueryParamType Type { get; set; }

        /// <summary>
        /// Creates a new query parameter with the given name and type
        /// </summary>
        /// <param name="name">The name for the parameter</param>
        /// <param name="type">The type for the parameter</param>
        public QueryParam(string name, QueryParamType type)
        {
            Name = name;
            Type = type;
        }
    }
}
