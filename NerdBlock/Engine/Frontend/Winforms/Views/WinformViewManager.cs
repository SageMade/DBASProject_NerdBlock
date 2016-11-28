using System;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public static class WinformViewManager
    {
        private static MainForm myMainForm;
        private static Panel myContentPanel;

        static WinformViewManager()
        {
            myMainForm = new MainForm();
            myContentPanel = (Panel)myMainForm.Controls["pnlContent"];
        }

        public static void Init(ViewBase startView)
        {
            myContentPanel.Controls.Add(startView);
        }

        public static void ShowView(ViewBase control)
        {
            throw new NotImplementedException();
        }
    }
}