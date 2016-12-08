using System;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using Model = NerdBlock.Engine.Backend.Models;
using System.Windows.Forms;
using NerdBlock.Engine.Backend;
using System.Collections.Generic;

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
            btnAddProductToBlock.Click += (X, Y) =>
            {
                if (dgvAddItem.SelectedRows.Count > 0)
                {
                    ViewManager.CurrentMap.SetInput("ProductToAdd", DataAccess.FromPrimaryKey<Model.Product>(dgvAddItem.SelectedRows[0].Cells["ProductId"].Value));
                    AttemptAction("insert_block_item");
                }
                else
                    ViewManager.ShowFlash("Please select a product", FlashMessageType.Neutral);
            };
            
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            dgvItems.Rows.Clear();

            List<Model.Product> items = Session.Get<List<Model.Product>>("AddingProducts");
            
            if (items != null)
            {
                for (int index = 0; index < items.Count; index++)
                {
                    DataGridViewRow row = dgvItems.Rows[dgvItems.Rows.Add()];

                    row.Cells["pId"].Value = items[index].ProductId;
                    row.Cells["pName"].Value = items[index].Name;
                    row.Cells["pWidth"].Value = items[index].Width;
                    row.Cells["pHeight"].Value = items[index].Height;
                    row.Cells["pDepth"].Value = items[index].Depth;
                    row.Cells["pDescription"].Value = items[index].Description;
                }
            }

            map.SetOutput("AllProducts", DataAccess.Execute("select * from tblproduct"));
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
