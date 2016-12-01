using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend.Winforms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms
{
    public class WinformViewManager : IViewManagerImplementation
    {
        private MainForm myMainForm;
        private Panel myContentPanel;

        private Dictionary<string, IView> myViews;

        public IView CurrentView
        {
            get;
            private set;
        }

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
                myContentPanel.Controls[index].Hide();

            control.Anchor = AnchorStyles.None;
            control.Left = (myContentPanel.Width / 2) - (control.Width / 2);
            control.Top = (myContentPanel.Height / 2) - (control.Height / 2);

            if (!myContentPanel.Controls.Contains(control))
                myContentPanel.Controls.Add(control);

            control.LoadView();
            control.Show();

            CurrentView = control;
        }
        
        public IView GetView(string name)
        {
            return myViews[name];
        }

        public void ShowView(IView view)
        {
            ViewBase control = view as ViewBase;
            ShowView(control);
        }

        public void RegisterView(string name, IView view)
        {
            myViews.Add(name, view);
        }

        public void ReflectLoadViews(Assembly assembly = null)
        {
            if (assembly == null)
                assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes().Where(
                T => T.BaseType == typeof(ViewBase)).ToArray();

            for (int index = 0; index < types.Length; index++)
            {
                ViewBase item = Activator.CreateInstance(types[index]) as ViewBase;
                ViewManager.RegisterView(types[index].Name, item);
            }
        }

        public void ShowFlash(string message, FlashMessageType flashType)
        {
            switch (flashType)
            {
                case FlashMessageType.Neutral:
                 MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case FlashMessageType.Good:
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
                case FlashMessageType.Bad:
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case FlashMessageType.Fatal:
                    MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }

        public void PopulateList<ValueType, TargetType>(TargetType targetObject) where ValueType : new()
        {
            if (typeof(TargetType) == typeof(ComboBox))
            {
                ValueType[] values = DataAccess.SelectAll<ValueType>();

                ComboBox target = targetObject as ComboBox;

                for(int index = 0; index < values.Length; index ++)
                {
                    target.Items.Add(values[index]);
                }

                if (values.Length > 0 && target.DropDownStyle == ComboBoxStyle.DropDownList)
                    target.SelectedIndex = 0;
            }
        }

        public void PopulateFromQuery<TargetType>(TargetType targetObject, IQueryResult query, int nameIndex = 0)
        {
            if (typeof(TargetType) == typeof(ComboBox))
            {
                ComboBox target = targetObject as ComboBox;

                for (int index = 0; index < query.NumRows; index++)
                {
                    target.Items.Add(query.Row[nameIndex]);
                    query.MoveNext();
                }
            }
        }

        public void InitAuth(object authObject)
        {
            EmployeeRole role = authObject as EmployeeRole;

            if (role != null)
            {
                foreach (KeyValuePair<string, ToolStripItem> kvp in myMainForm.ToolStripMapping.Mapping)
                {
                    kvp.Value.Visible = role.HasAccess(kvp.Key);
                }
            }
        }

        public void CloseProgram()
        {
            myMainForm.Close();
        }
    }
}