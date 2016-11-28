using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms
{
    /// <summary>
    /// Represents an IFiller implementation that fills a label with a value
    /// </summary>
    /// <typeparam name="SourceType">The type that will provide the source values (ex. Employee)</typeparam>
    public class LabelFiller<SourceType> : FillerBase<SourceType>
    {
        /// <summary>
        /// Creates a new label filler for the given label and value source
        /// </summary>
        /// <param name="label">The label to display the values in</param>
        /// <param name="sourceName">The name of the property in SourceType to get the source value from</param>
        public LabelFiller(Label label, string sourceName) : base(label, sourceName, "Text") { }
    }
}
