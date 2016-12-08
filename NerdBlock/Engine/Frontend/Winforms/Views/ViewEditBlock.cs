using System;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using Model = NerdBlock.Engine.Backend.Models;
using System.Windows.Forms;
using NerdBlock.Engine.Backend;
using System.Collections.Generic;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class ViewEditBlock : ViewBase
    {
        public ViewEditBlock()
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

            btnSave.Click += (X, Y) => AttemptAction("update_block");
            btnAddProductToBlock.Click += (X, Y) =>
            {
                if (dgvAddItem.SelectedRows.Count > 0)
                {
                    ViewManager.CurrentMap.SetInput("ProductToAdd", DataAccess.FromPrimaryKey<Model.Product>(dgvAddItem.SelectedRows[0].Cells["ProductId"].Value));
                    AttemptAction("insert_block_item_edit");
                }
                else
                    ViewManager.ShowFlash("Please select a product", FlashMessageType.Neutral);
            };
            
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            dgvItems.Rows.Clear();

            List<Model.Product> items = Session.Get<List<Model.Product>>("AddingProducts");

            if (map.HasInput<Model.Block>("Block.Input"))
            {
                if (items == null)
                {
                    Session.Set("AddingProducts", new List<Model.Product>());
                    items = Session.Get<List<Model.Product>>("AddingProducts");
                }

                Model.Block block = map.GetInput<Model.Block>("Block.Input");
                map.SetInput<Model.Block>("Block.Input", null);
                map.SetInput("Block", block);

                Model.BlockItem toMatch = new Model.BlockItem();
                toMatch.BlockId = block;

                Model.BlockItem[] matches = DataAccess.Match(toMatch);

                for(int index = 0; index < matches.Length; index ++)
                {
                    items.Add(DataAccess.FromPrimaryKey<Model.Product>(matches[index].ProducId.ProductId));
                }

                map.SetInput("Block.Title", block.Title);
                map.SetInput("Block.Description", block.Description);
                map.SetInput("Block.Series", block.SeriesId);
                map.SetInput("Block.ShipByDate", block.ShipByDate);
            }

            
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
