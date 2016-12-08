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
            Outputs.Add(new DataGridOutput("Order", dgvOrder));

            Inputs.Add(new TextBoxInput("Product.QuantityOrdered", txtQuantityOrdered));
            Inputs.Add(new TextBoxInput("Product.ProductName", txtProductName));
            Inputs.Add(new TextBoxInput("Product.Width", txtWidth));
            Inputs.Add(new TextBoxInput("Product.Height", txtHeight));
            Inputs.Add(new TextBoxInput("Product.Depth", txtDepth));
            Inputs.Add(new TextBoxInput("Product.Description", txtDescription));

            //ViewManager.PopulateFromQuery(cbProductID, DataAccess.Execute("select productid from tblproduct group by productid order by productid"));
            //ViewManager.PopulateFromQuery(cbSupplierID, DataAccess.Execute("select supplierid from tblsupplier group by supplierid order by supplierid"));

            btnAddOrder.Click += (X, Y) => AttemptAction("order_insert");

            btnAdd.Click += (X, Y) => AttemptAction("order_add_item");
            
            btnAddSupplier.Click += (X, Y) => AttemptAction("goto_supplier_add");
        }
    }
}
