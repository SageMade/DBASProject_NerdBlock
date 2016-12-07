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
    public partial class ViewEditOrder : ViewBase
    {
        public ViewEditOrder()
        {
            InitializeComponent();

            Outputs.Add(new ModelPopulatedComboBox<Supplier>("SupplierId", cbSupplierID));
            Inputs.Add(new TextBoxInput("QuantityOrdered", txtQuantityOrdered));
            Inputs.Add(new TextBoxInput("ProductName", txtProductName));
            Inputs.Add(new TextBoxInput("Width", txtWidth));
            Inputs.Add(new TextBoxInput("Height", txtHeight));
            Inputs.Add(new TextBoxInput("Depth", txtDepth));
            Inputs.Add(new TextBoxInput("Description", txtDescription));
            Outputs.Add(new DataGridOutput("Order", dgvOrder));

            btnEditOrder.Click += (X, Y) => AttemptAction("update_order");
            btnAdd.Click += (X, Y) => AttemptAction("insert_product");
            btnAddSupplier.Click += (X, Y) => AttemptAction("goto_supplier_add");
        }
    }
}
