using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Implementation
{
    public class ComboBoxInput : IInput
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

        public ComboBoxInput(string valueName, ComboBox input)
        {
            Name = valueName;
            myControl = input;
        }
    }
}
