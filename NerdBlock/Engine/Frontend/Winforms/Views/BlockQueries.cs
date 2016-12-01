using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.Frontend.Implementation;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Backend;
using NerdBlock.Engine.LogicLayer;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class BlockQueries : ViewBase
    {
        public BlockQueries()
        {
            InitializeComponent();
            //Input
            Inputs.Add(new ComboBoxValueInput("Block.genre", cbGenre));
            Inputs.Add(new ComboBoxValueInput("Block.series", cbSeries));
            Inputs.Add(new ComboBoxValueInput("Sortby", cbSort));

            //Output
            //Add output for list box.

            //Controls
            btnAdd.Click += (X, Y) => AttemptAction("goto_block");

            btnEdit.Click += (X, Y) =>
            {
                Context.SetValue("TargetBlock", lstSeries.SelectedItem);
                AttemptAction("goto_block");
            };

        }

        private void BlockQueries_Load(object sender, EventArgs e)
        {

        }
    }
}
