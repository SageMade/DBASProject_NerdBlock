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
    public partial class AddProduct : ViewBase
    {
        public AddProduct()
        {
            InitializeComponent();

            Inputs.Add(new TextBoxInput("ProductId", txtProductID));
            Inputs.Add(new TextBoxInput("ProductName", txtProductName));
            Inputs.Add(new TextBoxInput("Width", txtWidth));
            Inputs.Add(new TextBoxInput("Height", txtHeight));
            Inputs.Add(new TextBoxInput("Depth", txtDepth));
            Inputs.Add(new TextBoxInput("Description", txtDescription));

            btnAdd.Click += (X, Y) => AttemptAction("insert_product");
        }
    }
}
