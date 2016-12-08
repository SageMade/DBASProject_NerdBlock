using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend.Winforms.Implementation;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Backend;
using NerdBlock.Properties;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class Inventory : ViewBase
    {
        public Inventory()
        {
            InitializeComponent();

            //Output - 1
            Outputs.Add(new DataGridOutput("Inventory", dgvInventory));
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            map.SetOutput("Items", DataAccess.Execute("Select * from products", new[] { new QueryParam("orderId", QueryParamType.Integer) }, new object[] { order.OrderId.Value }));
        }
    }
}

