using System;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    internal class ModelPopulatedComboBox<T> : IOutput where T : new()
    {
        private ComboBox myControl;
        
        public string Name
        {
            get;
            set;
        }

        public ModelPopulatedComboBox(ComboBox control)
        {
            this.myControl = control;
        }

        public object Value
        {
            set { myControl.SelectedValue = myControl.Items.Contains(value) ? value != null ? myControl.SelectedValue : value : value; }
        }

        public void Fill(IoMap map)
        {
            ViewManager.PopulateList<T, ComboBox>(myControl);
        }
    }
}