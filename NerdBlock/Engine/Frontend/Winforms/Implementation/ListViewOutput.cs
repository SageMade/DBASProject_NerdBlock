using NerdBlock.Engine.Backend;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IOutput connector for a list view control
    /// </summary>
    public class ListViewOutput : IOutput
    {
        private ListBox myView;

        /// <summary>
        /// Gets or sets the name of the input in the input map
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Sets the value of the output
        /// </summary>
        public object Value
        {
            set { __SetValue(value); }
        }

        /// <summary>
        /// Creates a new list view output with the given map name and checkbox input
        /// </summary>
        /// <param name="contextName">The name of the output in the output map</param>
        /// <param name="label">The checkbox to use as an output</param>
        public ListViewOutput(string name, ListBox view)
        {
            Name = name;
            myView = view;
        }

        /// <summary>
        /// Handles setting the value
        /// </summary>
        /// <param name="value">The value to set, should be either a query result or object array</param>
        private void __SetValue(object value)
        {
            // Handle query results
            if (value is IQueryResult)
            {
                // Get the value as a query result
                IQueryResult result = value as IQueryResult;

                // Clear the views items
                myView.Items.Clear();

                // Iterate as long as we have another row
                while(result.HasRow)
                {
                    // Create the row
                    string line = "";

                    // Iterate over our query result row items and add them as a string to the line
                    for (int index = 0; index < result.Row.ItemArray.Length; index++)
                        line += result.Row[index]?.ToString() + "\t";

                    // add the line to the list view
                    myView.Items.Add(line);

                    // move to the next result
                    result.MoveNext();
                }
            }
            // Handle item arrays
            else if (value is Array)
            {
                // Get the value as an array
                Array collection = value as Array;

                // Clear the views items
                myView.Items.Clear();

                // Only do work if we have items
                if (collection.Length > 0)
                {
                    // Get the item type and it's properties
                    Type itemType = collection.GetValue(0).GetType();
                    PropertyInfo[] properties = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    // Iterate over all items in the array
                    for (int index = 0; index < collection.Length; index++)
                    {
                        // Start the line
                        string line = "";

                        // iterate over all properties and append to line
                        for (int pIndex = 0; pIndex < properties.Length; pIndex++)
                            line += properties[pIndex].GetValue(collection.GetValue(index))?.ToString() + "    ";

                        // Add the line
                        myView.Items.Add(line);
                    }
                }
            }
        }

        public void Fill(IoMap map)
        {
            if (map.HasOutput(Name))
                Value = map.GetOutput<object>(Name);
        }
    }
}
