using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Implementation
{
    public class ComboBoxTextInput : IInput
    {
        private ComboBox myControl;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            get { return myControl.Text; }
        }

        public ComboBoxTextInput(string valueName, ComboBox input)
        {
            Name = valueName;
            myControl = input;
        }
    }
}
