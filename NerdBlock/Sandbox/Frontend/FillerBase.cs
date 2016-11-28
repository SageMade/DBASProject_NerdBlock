using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Sandbox.Frontend
{
    public class FillerBase<SourceVal> : IFillable
    {
        PropertyInfo myValueSource;
        PropertyInfo myTargetProperty;
        Control myTargetControl;

        public FillerBase(Control target, string valueName, string targetName)
        {
            myTargetControl = target;

            myValueSource = typeof(SourceVal).GetProperty(valueName, BindingFlags.Public | BindingFlags.Instance);
            myTargetProperty = myTargetControl.GetType().GetProperty(targetName, BindingFlags.Public | BindingFlags.Instance);
        }

        public virtual void Fill(object item)
        {
            myTargetProperty.SetValue(myTargetControl, Convert.ChangeType(__GetSouce(item), myTargetProperty.PropertyType));
        }

        protected virtual object __GetSouce(object item)
        {
            return myValueSource.GetValue(item);
        }
    }
}
