using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    public class LabelOutput : IOutput
    {
        private Label myControl;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            set
            {
                myControl.Text = value?.ToString();
            }
        }

        public LabelOutput(string contextName, Label label)
        {
            Name = contextName;
            myControl = label;
        }
    }
}
