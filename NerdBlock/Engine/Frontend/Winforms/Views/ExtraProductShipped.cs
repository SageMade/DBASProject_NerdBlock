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
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Backend;
using NerdBlock.Engine.LogicLayer;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class ExtraProductShipped : ViewBase
    {
        public ExtraProductShipped()
        {
            InitializeComponent();

            //Inputs.Add(new TextBoxInput("Product.Name", txtProductName));
            

            //btnAddProductToOverStock.Click += (X, Y) => AttemptAction("insert_extra_product");

        }

        protected override void LoadMyViewContext(IoMap map)
        {
            dgvExtraProduct.Rows.Clear();

            List<Product> items = Session.Get<List<Product>>("AddingProducts");


            if (items != null)
            {
                for (int index = 0; index < items.Count; index++)
                {
                    DataGridViewRow row = dgvExtraProduct.Rows[dgvExtraProduct.Rows.Add()];

                    row.Cells["iName"].Value = items[index].Name;
                    row.Cells["iQuantity"].Value = items[index].Stock;
                    row.Cells["iDescription"].Value = items[index].Description;

                }
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            (dgvAddExtra.DataSource as BindingSource).Filter = string.Format("Name LIKE '%{0}%' OR Description LIKE '%{0}%'", txtProductName.Text);
        }
    }
}
