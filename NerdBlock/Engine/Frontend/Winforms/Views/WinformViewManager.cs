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
            myContentPanel = (Panel)myMainForm.Controls["pnlMainContent"];
        }

        public static void Run(string viewName)
        {
            myContentPanel.Controls.Add((ViewBase)ViewManager.GetView(viewName));

            ShowView(viewName);

            myMainForm.ShowDialog();
        }

        public static void ShowView(string viewName)
        {
            ShowView((ViewBase)ViewManager.GetView(viewName));
        }

        public static void ShowView(ViewBase control)
        {
            for (int index = 0; index < myContentPanel.Controls.Count; index++)
                myContentPanel.Controls[index].Dispose();

            control.Anchor = AnchorStyles.None;
            control.Left = (myContentPanel.Width / 2) - (control.Width / 2);
            control.Top = 0;

            myContentPanel.Controls.Add(control);
        }
    }
}