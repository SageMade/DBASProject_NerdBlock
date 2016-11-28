using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents a view with fillable view elements
    /// </summary>
    public interface IViewFillable
    {
        /// <summary>
        /// Gets the fillable element with the given name
        /// </summary>
        /// <param name="name">The name of the element to fill</param>
        /// <returns>The IFillable element at the given index</returns>
        IFillable this[string name] { get; }

        /// <summary>
        /// Gets the fillable element with the given index
        /// </summary>
        /// <param name="index">The index of the element to fill</param>
        /// <returns>The IFillable element at the given index</returns>
        IFillable this[int index] { get; }

        /// <summary>
        /// Gets the number of fillable elements in the view
        /// </summary>
        int FillableCount { get; }

        /// <summary>
        /// Handles filling the view with a source element
        /// </summary>
        /// <param name="value">The value to fill with</param>
        void FillFrom(object value);
    }
}
