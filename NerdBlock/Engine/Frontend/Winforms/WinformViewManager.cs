using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms
{
    /// <summary>
    /// A windows forms implementation of the IViewManager
    /// </summary>
    public class WinformViewManager : IViewManagerImplementation
    {
        private MainForm myMainForm;
        private Panel myContentPanel;

        private Dictionary<string, IView> myViews;

        /// <summary>
        /// Gets the current view being displayed
        /// </summary>
        public IView CurrentView
        {
            get;
            private set;
        }

        /// <summary>
        /// Create a new windows forms view manager
        /// </summary>
        public WinformViewManager()
        {
            myMainForm = new MainForm();
            myContentPanel = (Panel)myMainForm.Controls["pnlMainContent"];

            myViews = new Dictionary<string, IView>();
        }

        /// <summary>
        /// Starts the application, displaying the given initial view
        /// </summary>
        /// <param name="initialView">The name of the initial view to display</param>
        public void Run(string viewName)
        {
            myContentPanel.Controls.Add((ViewBase)ViewManager.GetView(viewName));

            ShowView(viewName, new IoMap());

            myMainForm.ShowDialog();
        }

        /// <summary>
        /// Displays the view with the given name to the user
        /// </summary>
        /// <param name="viewName">The name of the view to display</param>
        public void ShowView(string viewName, IoMap map)
        {
            ShowView((ViewBase)ViewManager.GetView(viewName), map);
        }

        /// <summary>
        /// Displays the view to the user
        /// </summary>
        /// <param name="control">The view to display</param>
        public void ShowView(ViewBase control, IoMap map)
        {
            for (int index = 0; index < myContentPanel.Controls.Count; index++)
                myContentPanel.Controls[index].Hide();

            control.Anchor = AnchorStyles.None;
            control.Left = (myContentPanel.Width / 2) - (control.Width / 2);
            control.Top = (myContentPanel.Height / 2) - (control.Height / 2);

            if (!myContentPanel.Controls.Contains(control))
                myContentPanel.Controls.Add(control);

            control.LoadView(map);
            control.Show();

            CurrentView = control;
        }

        /// <summary>
        /// Gets the view with the given name
        /// </summary>
        /// <param name="name">The name of the view to get</param>
        /// <returns>The view associated with the given name</returns>
        public IView GetView(string name)
        {
            return myViews[name];
        }

        /// <summary>
        /// Displays the view to the user
        /// </summary>
        /// <param name="view">The view to display</param>
        public void ShowView(IView view, IoMap map)
        {
            ViewBase control = view as ViewBase;
            ShowView(control, map);
        }

        /// <summary>
        /// Register a view with the view manager
        /// </summary>
        /// <param name="name">The name of the view to register</param>
        /// <param name="view">The view to register</param>
        public void RegisterView(string name, IView view)
        {
            myViews.Add(name, view);
        }

        /// <summary>
        /// Handles loading and generating the views from runtime reflection
        /// </summary>
        /// <param name="assembly">The assemly to search for IView implementations in</param>
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

        /// <summary>
        /// Shows a flash message or dialog with the given content
        /// </summary>
        /// <param name="message">The text to display in the flash message</param>
        /// <param name="flashType">The type of flash message to display</param>
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

        /// <summary>
        /// Populates an object from all instances of a given model type
        /// </summary>
        /// <typeparam name="ValueType">The type of model to fill with</typeparam>
        /// <typeparam name="TargetType">The type of the target object to fill</typeparam>
        /// <param name="targetObject">The target object to populate</param>
        public void PopulateList<ValueType, TargetType>(TargetType targetObject) where ValueType : new()
        {
            if (typeof(TargetType) == typeof(ComboBox))
            {
                ValueType[] values = DataAccess.SelectAll<ValueType>();

                ComboBox target = targetObject as ComboBox;
                target.Items.Clear();

                for(int index = 0; index < values.Length; index ++)
                {
                    target.Items.Add(values[index]);
                }

                if (values.Length > 0 && target.DropDownStyle == ComboBoxStyle.DropDownList)
                    target.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Populates an object from a query result
        /// </summary>
        /// <typeparam name="TargetType">The type of the target object to fill</typeparam>
        /// <param name="targetObject">The target object to populate</param>
        /// <param name="queryResult">The query to populate from</param>
        /// <param name="nameIndex">The index of the name within the query</param>
        public void PopulateFromQuery<TargetType>(TargetType targetObject, IQueryResult query, int nameIndex = 0)
        {
            if (typeof(TargetType) == typeof(ComboBox))
            {
                ComboBox target = targetObject as ComboBox;
                target.Items.Clear();

                for (int index = 0; index < query.NumRows; index++)
                {
                    target.Items.Add(query.Row[nameIndex]);
                    query.MoveNext();
                }
            }
        }

        /// <summary>
        /// Handles when the auth engine's authorization has changed
        /// </summary>
        public void HandleAuthChanged()
        {
            Employee auth = Auth.User as Employee;

            myMainForm.ToolStripMapping.VerifyAuth();
            
            ToolStrip toolStrip = (ToolStrip)myMainForm.Controls["mnuMainBar"];

            foreach (ToolStripMenuItem tsm in toolStrip.Items)
            {
                bool show = false;

                foreach (ToolStripItem tsi in tsm.DropDownItems)
                    if (tsi.Available && myMainForm.ToolStripMapping.HasEntry(tsi))
                    {
                        show = true;
                        break;
                    }

                tsm.Visible = show;
            }
        }

        private bool __IsMenuItem(Control control)
        {
            return control.GetType() == typeof(ToolStripMenuItem);
        }

        /// <summary>
        /// Close the program
        /// </summary>
        public void CloseProgram()
        {
            myMainForm.Close();
        }
    }
}