using System;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IOutput connector for a checkbox control
    /// </summary>
    public class CheckBoxOutput : IOutput
    {
        private CheckBox myControl;

        /// <summary>
        /// Gets or sets the name of the output in the output map
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
            set { myControl.Checked = value is bool ? (bool)value : false; }
        }

        /// <summary>
        /// Creates a new checkbox output with the given map name and checkbox input
        /// </summary>
        /// <param name="contextName">The name of the output in the output map</param>
        /// <param name="label">The checkbox to use as an output</param>
        public CheckBoxOutput(string contextName, CheckBox label)
        {
            Name = contextName;
            myControl = label;
        }

        public void Fill(IoMap map)
        {
            if (map.HasOutput<bool>(Name))
                myControl.Checked = map.GetOutput<bool>(Name);
            else
                myControl.Checked = false;
        }
    }
}
