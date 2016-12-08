using System;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using Model = NerdBlock.Engine.Backend.Models;
using System.Windows.Forms;
using NerdBlock.Engine.Backend;

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

            Outputs.Add(new DataGridOutput("AllProducts", dgvAddItem));

            //Controls - 4 DONE

            btnSave.Click += (X, Y) => AttemptAction("insert_block");
            
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            map.SetOutput("AllProducts", DataAccess.Execute("select name as Name,width as Width,height as Height,depth as Depth,description as Description from tblproduct"));
        }

        private void AddEditBlock_Load(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            (dgvAddItem.DataSource as BindingSource).Filter = string.Format("Name LIKE '%{0}%' OR Description LIKE '%{0}%'", txtProductName.Text);
        }
    }
}
