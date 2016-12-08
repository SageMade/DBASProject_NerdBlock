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

//Fields that do not need tools
//Orderid - Auto generated
//OrderedBy - Logged in user
//DateOrdered - Current date/time
namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class AddOrder : ViewBase
    {
        public AddOrder()
        {
            InitializeComponent();
            
            Outputs.Add(new ModelPopulatedComboBox<Supplier>("SupplierId", cbSupplierID));

            Inputs.Add(new ComboBoxValueInput("Order.Supplier", cbSupplierID));

            Inputs.Add(new TextBoxInput("Product.QuantityOrdered", txtQuantityOrdered));
            Inputs.Add(new TextBoxInput("Product.Name", txtProductName));
            Inputs.Add(new TextBoxInput("Product.Width", txtWidth));
            Inputs.Add(new TextBoxInput("Product.Height", txtHeight));
            Inputs.Add(new TextBoxInput("Product.Depth", txtDepth));
            Inputs.Add(new TextBoxInput("Product.Description", txtDescription));
            Inputs.Add(new TextBoxInput("Product.BatchCost", txtBatchCost));

            //ViewManager.PopulateFromQuery(cbProductID, DataAccess.Execute("select productid from tblproduct group by productid order by productid"));
            //ViewManager.PopulateFromQuery(cbSupplierID, DataAccess.Execute("select supplierid from tblsupplier group by supplierid order by supplierid"));

            btnAddOrder.Click += (X, Y) => AttemptAction("order_insert");

            btnAdd.Click += (X, Y) => AttemptAction("order_insert_item");
            
            btnAddSupplier.Click += (X, Y) => AttemptAction("goto_add_supplier");
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            dgvOrder.Rows.Clear();

            List<OrderLineitem> items = Session.Get<List<OrderLineitem>>("WorkingOrderItems");

            decimal totalCost = 0;

            if (items != null)
            {
                for(int index = 0; index < items.Count; index ++)
                {
                    DataGridViewRow row = dgvOrder.Rows[dgvOrder.Rows.Add()];

                    row.Cells["ProdName"].Value = items[index].ProductId.Name;
                    row.Cells["Quantity"].Value = items[index].Quantity;
                    row.Cells["Price"].Value = items[index].BatchCost;

                    totalCost += items[index].BatchCost.Value;
                }
            }
        }
    }
}
