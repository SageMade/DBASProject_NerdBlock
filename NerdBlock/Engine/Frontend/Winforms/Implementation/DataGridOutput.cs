using NerdBlock.Engine.Backend;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IOutput connector for a data grid view control
    /// </summary>
    public class DataGridOutput : IOutput
    {
        private DataGridView myView;

        /// <summary>
        /// Gets or sets the name of the input in the input map
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Sets the value for this output. This should be either a query result or object array
        /// </summary>
        public object Value
        {
            set { __SetValue(value); }
        }

        /// <summary>
        /// Creates a new data grid output
        /// </summary>
        /// <param name="name">The name of the output in the output map</param>
        /// <param name="view">The control to use as output</param>
        public DataGridOutput(string name, DataGridView view)
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
            // Handle Query results
            if (value is IQueryResult)
            {
                // Get the input as a queryresult
                IQueryResult result = value as IQueryResult;
                // Generate a binding source for the query
                BindingSource bs = new BindingSource();
                bs.DataSource = result.Source.Tables[0];
                // Set the control's binding to the generated binding source
                myView.DataSource = bs;
            }
            // Handle arrays
            else if (value is Array)
            {
                // Gets the input as an array
                Array collection = value as Array;

                // Clear any existing rows
                myView.Rows.Clear();

                // Only work if we have values
                if (collection.Length > 0)
                {
                    // Get the item type in the collection
                    Type itemType = collection.GetValue(0).GetType();
                    // Get the properties for the type
                    PropertyInfo[] properties = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    // Iterate over all items in the array
                    for (int iIndex = 0; iIndex < collection.Length; iIndex++)
                    {
                        // Generate a row for the results
                        DataGridViewRow row = myView.Rows[myView.Rows.Add()];
                        
                        // Iterate over all the columns in the view
                        for (int index = 0; index < myView.Columns.Count; index++)
                        {

                            // Try to see if we have a property that matches the data property name
                            PropertyInfo pInfo = properties.Where(X => X.Name.ToLower().Equals(myView.Columns[index].DataPropertyName.ToLower())).FirstOrDefault();

                            // If we have a property info, update the cell in our row
                            if (pInfo != null)
                                row.Cells[myView.Columns[index].Name].Value = pInfo.GetValue(collection.GetValue(iIndex));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fills this IOutput from a given IO map
        /// </summary>
        /// <param name="map">The map to fill from</param>
        public void Fill(IoMap map)
        {
            if (map.HasOutput(Name))
                Value = map.GetOutput<object>(Name);
        }
    }
}
