using System;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IOutput connector for a textbox control
    /// </summary>
    public class TextBoxOutput : IOutput
    {
        private TextBox myControl;

        /// <summary>
        /// Gets or sets the name of the input in the input map
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Sets the value for the output
        /// </summary>
        public object Value
        {
            set { myControl.Text = value?.ToString(); }
        }

        /// <summary>
        /// Creates a new textbox output with the given map name and control
        /// </summary>
        /// <param name="contextName">The name of the output in the output map</param>
        /// <param name="control">The control to use as an output</param>
        public TextBoxOutput(string contextName, TextBox control)
        {
            Name = contextName;
            myControl = control;
        }

        /// <summary>
        /// Fills this IOutput from a given IO map
        /// </summary>
        /// <param name="map">The map to fill from</param>
        public void Fill(IoMap map)
        {
            if (map.HasOutput(Name))
                Value = map.GetOutput<object>(Name);
            else
                myControl.Text = "";
        }
    }
}
