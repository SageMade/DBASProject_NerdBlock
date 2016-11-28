using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Sandbox.Frontend
{
    /// <summary>
    /// A base implementation of IViewFillable that uses a dictionary to reference IFillables
    /// </summary>
    public abstract class ViewFillerBase : IViewFillable
    {
        /// <summary>
        /// Stores the filler instances
        /// </summary>
        protected Dictionary<string, IFillable> myFillers;

        /// <summary>
        /// Gets the IFillable with the given index
        /// </summary>
        /// <param name="index">The index of the element to get</param>
        /// <returns>The IFillable at the given index</returns>
        public IFillable this[int index]
        {
            get { return myFillers.Values.ElementAt(index); }
        }

        /// <summary>
        /// Gets the IFillable with the given name
        /// </summary>
        /// <param name="name">The name of the element to get</param>
        /// <returns>The IFillable with the given name</returns>
        public IFillable this[string name]
        {
            get { return myFillers[name]; }
        }

        /// <summary>
        /// Gets the number of fillable elements in this view
        /// </summary>
        public int FillableCount
        {
            get { return myFillers.Count; }
        }

        /// <summary>
        /// Creates a new view filler base and initializes the dictionary
        /// </summary>
        public ViewFillerBase()
        {
            myFillers = new Dictionary<string, IFillable>();
        }

        /// <summary>
        /// Adds a filler element to this view filler
        /// </summary>
        /// <param name="name">The internal name for the element</param>
        /// <param name="filler">The filler to add</param>
        public void AddFiller(string name, IFillable filler)
        {
            myFillers.Add(name, filler);
        }
        
        /// <summary>
        /// Fills this view filler with the given value
        /// </summary>
        /// <param name="value">The value to fill this view from</param>
        public void FillFrom(object value)
        {
            foreach (KeyValuePair<string, IFillable> kvp in myFillers)
            {
                kvp.Value.Fill(value);
            }
        }
    }
}
