using NerdBlock.Engine.LogicLayer;
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
        protected virtual List<IInput> Inputs
        {
            get;
            set;
        }

        public ViewBase()
        {
            Inputs = new List<IInput>();
        }

        public void ShowView()
        {
            ViewManager.Show(this);
        }

        public void AttemptAction(string actionName)
        {

            for(int index = 0; index < Inputs.Count; index ++)
            {
                IInput input = Inputs[index];
                Context.SetValue(input.Name, input.Value);
            }

            string msg = null;

            if (!LogicManager.TryPerformAction(actionName, out msg))
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Context.Clear();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ViewBase
            // 
            this.Name = "ViewBase";
            this.ResumeLayout(false);

        }
    }
}
