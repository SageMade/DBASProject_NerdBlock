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
        protected virtual List<IOutput> Outputs
        {
            get;
            set;
        }

        public ViewBase()
        {
            Inputs = new List<IInput>();
            Outputs = new List<IOutput>();
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

        public void ShowView()
        {

            ViewManager.Show(this);
        }

        public void LoadView()
        {
            for (int index = 0; index < Outputs.Count; index++)
                Outputs[index].Value = Context.Values[Outputs[index].Name];
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
    }
}
