using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    public class CheckBoxOutput : IOutput
    {
        private CheckBox myControl;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            set
            {
                myControl.Checked = value is bool ? (bool)value : false;
            }
        }

        public CheckBoxOutput(string contextName, CheckBox label)
        {
            Name = contextName;
            myControl = label;
        }
    }
}
