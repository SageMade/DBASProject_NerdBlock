using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms
{
    /// <summary>
    /// Represents a reflection-based approach to the IFillable interface. This is for the Winforms frontend only
    /// </summary>
    /// <typeparam name="SourceVal">The Type that will be used to provide the source values</typeparam>
    public class FillerBase<SourceVal> : IFillable
    {
        PropertyInfo myValueSource;
        PropertyInfo myTargetProperty;
        Control myTargetControl;

        /// <summary>
        /// Creates a new FillerBase with the given control, value name, and target name
        /// </summary>
        /// <param name="target">The target control that will display the value</param>
        /// <param name="valueName">The name of the property in SourceVal that will provide the data</param>
        /// <param name="targetName">The name of the property in the control that will accept the value</param>
        public FillerBase(Control target, string valueName, string targetName)
        {
            myTargetControl = target;

            myValueSource = typeof(SourceVal).GetProperty(valueName, BindingFlags.Public | BindingFlags.Instance);
            myTargetProperty = myTargetControl.GetType().GetProperty(targetName, BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>
        /// Implements the IFillable interface and handles filling the target control with data
        /// </summary>
        /// <param name="item">The data item that will provide the source values</param>
        public virtual void Fill(object item)
        {
            // We use reflection gets and sets and attempt to convert the source type to the receiving propertie's type
            myTargetProperty.SetValue(myTargetControl, Convert.ChangeType(myValueSource.GetValue(item), myTargetProperty.PropertyType));
        }        
    }
}
