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

            Outputs.Add(new LabelOutput("OrderCost", lblOrderCost));
            Outputs.Add(new LabelOutput("OrderDate", lblOrderDate));
            Outputs.Add(new LabelOutput("OrderBy", lblOrderedBy));
            Outputs.Add(new LabelOutput("OrderID", lblOrderId));
            Outputs.Add(new LabelOutput("OrderSupp", lblSupplier));
            Outputs.Add(new DataGridOutput("Items", dgvItems));

        }
    }
}
