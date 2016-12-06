using System;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IInput connector for a text box control's text
    /// </summary>
    public class TextBoxInput : IInput
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
        /// Gets the value of the input
        /// </summary>
        public object Value
        {
            get { return myControl.Text; }
            set { myControl.Text = value == null ? "" : value.ToString(); }
        }

        /// <summary>
        /// Creates a new text box input
        /// </summary>
        /// <param name="valueName">The name of the input in the input map</param>
        /// <param name="input">The control to use as an input</param>
        public TextBoxInput(string valueName, TextBox textBox)
        {
            Name = valueName;
            myControl = textBox;
        }

        public void Fill(IoMap map)
        {
            if (map.HasOutput(Name))
                Value = map.GetOutput<object>(Name);
            else
                myControl.Text = "";
        }

        public void PopulateMap(IoMap currentMap)
        {
            currentMap.SetInput(Name, myControl.Text);
        }
    }
}
