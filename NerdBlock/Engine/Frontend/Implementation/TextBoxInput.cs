using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Implementation
{
    public class TextBoxInput : IInput
    {
        private TextBox myControl;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            get { return myControl.Text; }
        }

        public TextBoxInput(string valueName, TextBox textBox)
        {
            Name = valueName;
            myControl = textBox;
        }
    }
}
