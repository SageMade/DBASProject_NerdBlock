using System;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class BlockQueries : ViewBase
    {
        public BlockQueries()
        {
            InitializeComponent();
            //Input - 3 DONE
            Inputs.Add(new ComboBoxValueInput("Block.Genre", cbGenre));
            Inputs.Add(new ComboBoxValueInput("Block.Series", cbSeries));

            //Output - 3
            ViewManager.PopulateList<Backend.Models.Genre, ComboBox>(cbGenre);
            ViewManager.PopulateList<Backend.Models.BlockSeries, ComboBox>(cbSeries);
            //Listbox


            //Controls - 2 DONE
            btnAdd.Click += (X, Y) => AttemptAction("goto_block");

            btnEdit.Click += (X, Y) =>
            {
                ViewManager.CurrentMap.SetInput("TargetBlock", lstSeries.SelectedItem);
                AttemptAction("goto_block");
            };

        }
    }
}
