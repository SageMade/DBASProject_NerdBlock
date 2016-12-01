using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend;
using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class Blocks : ViewBase
    {
        public Blocks()
        {
            InitializeComponent();
            //Input
            Inputs.Add(new TextBoxInput("Block.title", txtTitle));
            Inputs.Add(new TextBoxInput("Block.description", txtDescription));
            Inputs.Add(new TextBoxInput("Block.custcost", txtCustCost));
            Inputs.Add(new ComboBoxTextInput("Block.Series", cbSeries));

            //Output
            //Label output
            //Listbox Output

            //Controls
            btnAddItem.Click += (X, Y) => AttemptAction("add_block");
            btnDelete.Click += (X, Y) => AttemptAction("delete_block");
            btnSave.Click += (X, Y) => AttemptAction("update_block");
            btnNew.Click += (X, Y) => AttemptAction("clear_block_view");

        }

        private void AddEditBlock_Load(object sender, EventArgs e)
        {

        }
    }
}
