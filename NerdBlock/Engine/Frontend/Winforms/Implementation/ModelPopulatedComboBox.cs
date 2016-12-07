using System;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IOutput element that is populated by a model list. This will call SelectAll to populate the control
    /// </summary>
    /// <typeparam name="T">The model type to populate with</typeparam>
    internal class ModelPopulatedComboBox<T> : IOutput where T : new()
    {
        private ComboBox myControl;

        /// <summary>
        /// Gets or sets this items name in the IO map, this is mostly ignored
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the value of this output field
        /// </summary>
        public object Value
        {
            set { myControl.SelectedValue = myControl.Items.Contains(value) ? value != null ? myControl.SelectedValue : value : value; }
        }

        /// <summary>
        /// Creates a new populated combo box
        /// </summary>
        /// <param name="control">The combo box to wrap around</param>
        public ModelPopulatedComboBox(ComboBox control)
        {
            myControl = control;
        }

        /// <summary>
        /// Creates a new populated combo box
        /// </summary>
        /// <param name="name">The name to assign to the output</param>
        /// <param name="control">The combo box to wrap around</param>
        public ModelPopulatedComboBox(string name, ComboBox control)
        {
            Name = name;
            myControl = control;
        }

        /// <summary>
        /// Fills this IOutput from a given IO map
        /// </summary>
        /// <param name="map">The map to fill from</param>
        public void Fill(IoMap map)
        {
            ViewManager.PopulateList<T, ComboBox>(myControl);
        }
    }
}