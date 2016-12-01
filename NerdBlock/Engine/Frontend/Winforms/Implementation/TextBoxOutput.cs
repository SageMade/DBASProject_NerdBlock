using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    public class TextBoxOutput : IOutput
    {
        private TextBox myControl;

        public string Name
        {
            get;
            set;
        }

        public object Value
        {
            set { myControl.Text = value?.ToString(); }
        }

        public TextBoxOutput(string contextName, TextBox control)
        {
            Name = contextName;
            myControl = control;
        }
    }
}
