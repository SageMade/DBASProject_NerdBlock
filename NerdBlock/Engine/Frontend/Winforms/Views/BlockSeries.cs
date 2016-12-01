using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class BlockSeries : ViewBase
    {
        public BlockSeries()
        {
            InitializeComponent();
            //Input 
            Inputs.Add(new ComboBoxValueInput("Block.Genre", cbGenre));
           
            //Output
            ViewManager.PopulateList<Genre, ComboBox>(cbGenre);
            //Add lbSeries

            //Controls
            btnBlocks.Click += (X, Y) =>
            {
                Context.SetValue("TargetSeries", lbSeries.SelectedItem);
                Context.SetValue("TargetGenre", cbGenre.SelectedItem);
                AttemptAction("goto_blockseries");
            };
        }

    }
}
