using NerdBlock.Engine.LogicLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

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
        
        protected virtual void LoadMyViewContext() { }

        public virtual void LoadView(IoMap map)
        {
            for (int index = 0; index < Inputs.Count; index++)
                Inputs[index].Fill(map);

            for (int index = 0; index < Outputs.Count; index++)
                Outputs[index].Fill(map);

            LoadMyViewContext();
        }

        public void AttemptAction(string actionName)
        {
            for(int index = 0; index < Inputs.Count; index ++)
                Inputs[index].PopulateMap(ViewManager.CurrentMap);

            string msg = null;

            if (!LogicManager.TryPerformAction(actionName, out msg))
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
