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

            Inputs.Add(new TextBoxInput("ProductName", txtProductName));
            Inputs.Add(new TextBoxInput("QuantityOrdered", txtQuantityOrdered));
            Inputs.Add(new TextBoxInput("TotalOrderPrice", txtTotalOrderPrice));
            Inputs.Add(new TextBoxInput("Address", txtAddress));
            Inputs.Add(new TextBoxInput("Phone", txtPhone));
            Inputs.Add(new TextBoxInput("DateOrdered", txtDateOrdered));
            Inputs.Add(new TextBoxInput("DateArrived", txtDateArrived));

            btnEditOrder.Click += (X, Y) => AttemptAction("update_order");
        }
    }
}
