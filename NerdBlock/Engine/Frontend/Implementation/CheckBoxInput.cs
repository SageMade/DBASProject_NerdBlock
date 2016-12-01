using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Implementation
{
    public class CheckBoxInput : IInput
    {
        private CheckBox myControl;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            get { return myControl.Checked; }
        }

        public CheckBoxInput(string valueName, CheckBox checkBox)
        {
            Name = valueName;
            myControl = checkBox;
        }
    }
}
