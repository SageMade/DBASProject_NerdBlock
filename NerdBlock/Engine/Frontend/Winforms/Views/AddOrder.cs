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

            Outputs.Add(new ModelPopulatedComboBox<Product>("ProductId", cbProductID));
            Outputs.Add(new ModelPopulatedComboBox<Supplier>("SupplierId", cbSupplierID));
            Inputs.Add(new TextBoxInput("QuantityOrdered", txtQuantityOrdered));

            //ViewManager.PopulateFromQuery(cbProductID, DataAccess.Execute("select productid from tblproduct group by productid order by productid"));
            //ViewManager.PopulateFromQuery(cbSupplierID, DataAccess.Execute("select supplierid from tblsupplier group by supplierid order by supplierid"));

            btnAddOrder.Click += (X, Y) => AttemptAction("insert_order");
            btnAddProduct.Click += (X, Y) => AttemptAction("goto_inventory_add");
            btnAddSupplier.Click += (X, Y) => AttemptAction("goto_supplier_add");
        }

        private void txtDateArrived_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        //Goes to AddSupplier
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Goes to AddProduct
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
