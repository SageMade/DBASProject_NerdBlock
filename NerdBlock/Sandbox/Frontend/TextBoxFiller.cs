using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Sandbox.Frontend
{
    public class TextBoxFiller<SourceType> : FillerBase<SourceType>
    {
        public TextBoxFiller(TextBox textBox, string sourceName) : base(textBox, sourceName, "Text") { }
    }
}
