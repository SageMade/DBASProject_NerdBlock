using System;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using Model = NerdBlock.Engine.Backend.Models;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class Blocks : ViewBase
    {
        public Blocks()
        {
            InitializeComponent();
            //Input - 4 DONE
            Inputs.Add(new TextBoxInput("Block.Title", txtTitle));
            Inputs.Add(new TextBoxInput("Block.Description", txtDescription));
            Inputs.Add(new DateTimeInput("Block.ShipByDate", dtpShipDate));
            Inputs.Add(new ComboBoxValueInput("Block.Series", cbSeries));

            //Output - 1
            Outputs.Add(new ModelPopulatedComboBox<Model.BlockSeries>("Series", cbSeries));

            //Controls - 4 DONE
            btnDelete.Click += (X, Y) => AttemptAction("delete_block");
            btnSave.Click += (X, Y) => AttemptAction("insert_block");
            
        }

        private void AddEditBlock_Load(object sender, EventArgs e)
        {

        }

    }
}
