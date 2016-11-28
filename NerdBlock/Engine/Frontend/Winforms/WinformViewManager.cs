using NerdBlock.Engine.Frontend.Winforms.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms
{
    public class WinformViewManager : IViewManagerImplementation
    {
        private MainForm myMainForm;
        private Panel myContentPanel;

        private Dictionary<string, IView> myViews;

        public WinformViewManager()
        {
            myMainForm = new MainForm();
            myContentPanel = (Panel)myMainForm.Controls["pnlMainContent"];

            myViews = new Dictionary<string, IView>();
        }

        public void Run(string viewName)
        {
            myContentPanel.Controls.Add((ViewBase)ViewManager.GetView(viewName));

            ShowView(viewName);

            myMainForm.ShowDialog();
        }

        public void ShowView(string viewName)
        {
            ShowView((ViewBase)ViewManager.GetView(viewName));
        }

        public void ShowView(ViewBase control)
        {
            for (int index = 0; index < myContentPanel.Controls.Count; index++)
                myContentPanel.Controls[index].Dispose();

            control.Anchor = AnchorStyles.None;
            control.Left = (myContentPanel.Width / 2) - (control.Width / 2);
            control.Top = (myContentPanel.Height / 2) - (control.Height / 2);

            myContentPanel.Controls.Add(control);
        }
        
        public IView GetView(string name)
        {
            return myViews[name];
        }

        public void ShowView(IView view)
        {
            ViewBase control = view as ViewBase;

            for (int index = 0; index < myContentPanel.Controls.Count; index++)
                myContentPanel.Controls[index].Dispose();

            control.Anchor = AnchorStyles.None;
            control.Left = (myContentPanel.Width / 2) - (control.Width / 2);
            control.Top = (myContentPanel.Height / 2) - (control.Height / 2);

            myContentPanel.Controls.Add(control);
        }

        public void RegisterView(string name, IView view)
        {
            myViews.Add(name, view);
        }
    }
}