using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents an object that is used to fill a field in a view control
    /// </summary>
    public interface IFillable
    {
        /// <summary>
        /// Fills the underlying view control with data
        /// </summary>
        /// <param name="item">The item to put into the control</param>
        void Fill(object item);
    }
}
