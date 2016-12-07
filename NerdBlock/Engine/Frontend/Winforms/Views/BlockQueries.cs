using System;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using System.Windows.Forms;
using NerdBlock.Engine.Backend.Models;

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
            Outputs.Add(new ModelPopulatedComboBox<Genre>("Block.Genre", cbGenre));
            Outputs.Add(new ModelPopulatedComboBox<BlockSeries>("Block.Genre", cbGenre));
            Outputs.Add(new DataGridOutput("Data", dgvData));

            //Controls - 2 DONE
            btnAdd.Click += (X, Y) => AttemptAction("goto_block");

            btnEdit.Click += (X, Y) =>
            {
                AttemptAction("goto_block");
            };

            cbGenre.SelectedIndexChanged += SearchFieldChanged;
        }

        protected override void LoadMyViewContext(IoMap map)
        {

        }

        private void SearchFieldChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
