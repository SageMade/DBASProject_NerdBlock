using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox
{
    /// <summary>
    /// Represents an item that supports C.R.U.D operations on the database
    /// <typeparam name="ChildClass">The type of the class that is implementing this interface</typeparam>
    /// </summary>
    public interface IModel<ChildClass>
    {
        /// <summary>
        /// Inserts this item into the database
        /// </summary>
        /// <returns>True if successful, false if otherwise</returns>
        bool Create();

        /// <summary>
        /// Handles reloading this model from the database
        /// </summary>
        /// <returns>True if successful, false if otherwise</returns>
        bool Read();

        /// <summary>
        /// Updates this item in the database
        /// </summary>
        /// <returns>True if successful, false if otherwise</returns>
        bool Update();

        /// <summary>
        /// Handles deleting this item from the database
        /// </summary>
        /// <returns>True if successful, false if otherwise</returns>
        bool Delete();        
    }
}
