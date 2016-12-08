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
using NerdBlock.Properties;

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

        protected override void LoadMyViewContext(IoMap map)
        {
            Order order = map.GetInput<Order>("Order.Selected");

            if (order != null)
            {
                map.SetOutput("Items", DataAccess.Execute(Resources.SelectProductInfo, new[] { new QueryParam("orderId", QueryParamType.Integer) }, new object[] { order.OrderId.Value }));

                map.SetOutput("OrderID", order.OrderId.Value);
                map.SetOutput("OrderBy", order.OrderedBy);
                map.SetOutput("OrderDate", order.DateOrdered.Value.ToLongDateString());
                map.SetOutput("OrderSupp", order.SupplierId.Company);

                map.SetOutput("OrderCost", DataAccess.Execute(string.Format("select Sum(lineitem.batchcost) as TotalCost from tblorderlineitem as lineitem where orderid={0}", order.OrderId.Value)).Row["TotalCost"]);
            }
        }


    }
}
