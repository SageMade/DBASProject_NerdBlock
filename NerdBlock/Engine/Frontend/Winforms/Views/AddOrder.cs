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

            //Outputs.Add(new ModelPopulatedComboBox<Product>("ProductId", cbProductID));

            Outputs.Add(new ModelPopulatedComboBox<Supplier>("SupplierId", cbSupplierID));
            Outputs.Add(new DataGridOutput("Order", dgvOrder));

            Inputs.Add(new TextBoxInput("QuantityOrdered", txtQuantityOrdered));
            Inputs.Add(new TextBoxInput("ProductName", txtProductName));
            Inputs.Add(new TextBoxInput("Width", txtWidth));
            Inputs.Add(new TextBoxInput("Height", txtHeight));
            Inputs.Add(new TextBoxInput("Depth", txtDepth));
            Inputs.Add(new TextBoxInput("Description", txtDescription));

            //ViewManager.PopulateFromQuery(cbProductID, DataAccess.Execute("select productid from tblproduct group by productid order by productid"));
            //ViewManager.PopulateFromQuery(cbSupplierID, DataAccess.Execute("select supplierid from tblsupplier group by supplierid order by supplierid"));

            btnAddOrder.Click += (X, Y) => AttemptAction("insert_order");

            btnAdd.Click += AddProductClicked; ;

            //btnAddProduct.Click += (X, Y) => AttemptAction("goto_inventory_add");

            btnAddSupplier.Click += (X, Y) => AttemptAction("goto_supplier_add");
        }

        private void AddProductClicked(object sender, EventArgs e)
        {
            string quantitiyText = Inputs["QuantityOrdered"].Value as string;
        }
    }
}
