using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public abstract class ViewBase : UserControl, IView
    {
        public void ShowView()
        {
            WinformViewManager.ShowView(this);
        }
    }
}
