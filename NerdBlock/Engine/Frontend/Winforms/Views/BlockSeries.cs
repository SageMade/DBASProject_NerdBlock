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
            //Input - DONE
            Inputs.Add(new ComboBoxValueInput("Block.Genre", cbGenre));
           
            //Output - 2
            ViewManager.PopulateList<Genre, ComboBox>(cbGenre);
            //Add lstSeries

            //Controls - 1 DONE
            btnBlocks.Click += (X, Y) =>
            {
                Context.SetValue("TargetSeries", lstSeries.SelectedItem);
                Context.SetValue("TargetGenre", cbGenre.SelectedItem);
                AttemptAction("goto_blockseries");
            };
        }

    }
}
