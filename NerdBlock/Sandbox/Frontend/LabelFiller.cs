using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Sandbox.Frontend
{
    public class LabelFiller<SourceType> : FillerBase<SourceType>
    {
        public LabelFiller(Label label, string sourceName) : base(label, sourceName, "Text") { }
    }
}
