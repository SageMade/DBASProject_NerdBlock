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

            Inputs.Add(new TextBoxInput("Product.Name", txtProductName));
            Inputs.Add(new TextBoxInput("Product.Quantity", txtQuantity));
            Inputs.Add(new TextBoxInput("Product.Price", txtPrice));

            btnAdd.Click += (X, Y) => AttemptAction("insert_extra_product");

        }

        protected override void LoadMyViewContext(IoMap map)
        {
            dgvExtraProduct.Rows.Clear();

            List<OrderLineitem> items = Session.Get<List<OrderLineitem>>("WorkingOrderItems");

            decimal totalCost = 0;

            if (items != null)
            {
                for (int index = 0; index < items.Count; index++)
                {
                    DataGridViewRow row = dgvExtraProduct.Rows[dgvExtraProduct.Rows.Add()];

                    row.Cells["ProdName"].Value = items[index].ProductId.Name;
                    row.Cells["Quantity"].Value = items[index].Quantity;
                    row.Cells["Price"].Value = items[index].BatchCost;

                    totalCost += items[index].BatchCost.Value;
                }
            }
        }
    }
}
