using System.Collections;
using System.Collections.Generic;

namespace NerdBlock.Engine
{
    /// <summary>
    /// A utility class that represents a collection of elements that can be accessed via name or index
    /// </summary>
    /// <typeparam name="T">The type to store in this colelction</typeparam>
    public class NamedCollection<T> : IEnumerable<T> where T : INamed
    {
        private List<T> myItems;
        private Dictionary<string, int> myKeyLookup;
        private bool isExecptionOnMissingName;

        /// <summary>
        /// Gets the number of items in the collection
        /// </summary>
        public int Count
        {
            get { return myItems.Count; }
        }
        /// <summary>
        /// Gets the item at the given index
        /// </summary>
        /// <param name="index">The index of the iterm to get</param>
        /// <returns>The item at the given index</returns>
        public T this[int index]
        {
            get { return myItems[index]; }
            set { myItems[index] = value; }
        }
        /// <summary>
        /// Gets the item with the given name. If IsExecptionOnMissingName is true, and the
        /// name is not found, an exception will be thrown, otherwise the default value for 
        /// the type will be returned
        /// </summary>
        /// <param name="index">The index of the iterm to get</param>
        /// <returns>The item at the given index</returns>
        public T this[string name]
        {
            get
            {
                if (myKeyLookup.ContainsKey(name))
                    return myItems[myKeyLookup[name]];
                else if (IsExecptionOnMissingName)
                    throw new KeyNotFoundException();
                else
                    return default(T);
            }
            set
            {
                if (myKeyLookup.ContainsKey(name))
                    myItems[myKeyLookup[name]] = value;
                else if (IsExecptionOnMissingName)
                    throw new KeyNotFoundException();
                else
                {
                    myItems.Add(value);
                    myKeyLookup.Add(name, myItems.Count - 1);
                }
            }
        }
        /// <summary>
        /// Gets or sets whether an exception should be thrown if the name does not exist
        /// in the colelction
        /// </summary>
        public bool IsExecptionOnMissingName
        {
            get { return isExecptionOnMissingName; }
            set { isExecptionOnMissingName = value; }
        }

        /// <summary>
        /// Creates a new named collection
        /// </summary>
        public NamedCollection()
        {
            isExecptionOnMissingName = true;
            myItems = new List<T>();
            myKeyLookup = new Dictionary<string, int>();
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add(T item)
        {
            myItems.Add(item);
            myKeyLookup.Add(item.Name, myItems.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return myItems.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return myItems.GetEnumerator();
        }
    }
}
