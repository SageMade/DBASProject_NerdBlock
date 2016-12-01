using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend
{
    public interface IOutput
    {
        /// <summary>
        /// Gets the name that this output uses. This will be put into the context before performing an action
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Sets the value for the output
        /// </summary>
        object Value { set; }
    }
}
