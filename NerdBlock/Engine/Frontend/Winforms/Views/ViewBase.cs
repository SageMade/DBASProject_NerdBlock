using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public class ViewBase : UserControl, IView
    {
        public ViewBase()
        {

        }

        public void ShowView()
        {
            WinformViewManager.ShowView(this);
        }
    }
}
