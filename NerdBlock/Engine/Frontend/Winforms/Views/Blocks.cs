using System;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class Blocks : ViewBase
    {
        public Blocks()
        {
            InitializeComponent();
            //Input - 4 DONE
            Inputs.Add(new TextBoxInput("Block.title", txtTitle));
            Inputs.Add(new TextBoxInput("Block.description", txtDescription));
            Inputs.Add(new TextBoxInput("Block.custcost", txtCustCost));
            Inputs.Add(new ComboBoxTextInput("Block.Series", cbSeries));

            //Output - 1
            //Listbox Output

            //Controls - 4 DONE
            //btnAddItem.Click += (X, Y) => AttemptAction("add_block");
            btnDelete.Click += (X, Y) => AttemptAction("delete_block");
            btnSave.Click += (X, Y) => AttemptAction("update_block");
            //btnNew.Click += (X, Y) => AttemptAction("clear_block_view");
            btnSave.Click += (X, Y) => AttemptAction("insert_block");
            
        }

        private void AddEditBlock_Load(object sender, EventArgs e)
        {

        }

    }
}
