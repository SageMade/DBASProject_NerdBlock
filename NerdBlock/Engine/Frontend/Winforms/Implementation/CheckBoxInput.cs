using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IInput connector for a checkbox control
    /// </summary>
    public class CheckBoxInput : IInput
    {
        private CheckBox myControl;

        /// <summary>
        /// Gets or sets the name of the input in the input map
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the value of the input
        /// </summary>
        public object Value
        {
            get { return myControl.Checked; }
            set { myControl.Checked = value is bool ? (bool)value : false; }
        }

        /// <summary>
        /// Creates a new checkbox input with the given map name and checkbox input
        /// </summary>
        /// <param name="valueName">The name of the input in the input map</param>
        /// <param name="checkBox">The checkbox to use as an input</param>
        public CheckBoxInput(string valueName, CheckBox checkBox)
        {
            Name = valueName;
            myControl = checkBox;
        }
    }
}
