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

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class OrderPage : ViewBase
    {
        public OrderPage()
        {
            InitializeComponent();

            //Inputs - 1
            Inputs.Add(new TextBoxInput("Order.ID", txtOrderID));

            //Outputs - 2
            Outputs.Add(new DataGridOutput("Orders", dgvOrders));
            Outputs.Add(new LabelOutput("#OfOrders", lblNumberOfOrders));

            //Controls - 1
            btnView.Click += (X, Y) =>
            {
                ViewManager.CurrentMap.SetInput("TargetItem", dgvOrders.SelectedRows[0]);
                AttemptAction("goto_view_edit_orders");
            };


        }

        private void OrderPage_Load(object sender, EventArgs e)
        {

        }
    }
}
