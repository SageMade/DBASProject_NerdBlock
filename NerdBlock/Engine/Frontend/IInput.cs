using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents an input element
    /// </summary>
    public interface IInput
    {
        /// <summary>
        /// Gets the name that this input uses. This will be put into the context before performing an action
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the value from the input
        /// </summary>
        object Value { get; }
    }
}
