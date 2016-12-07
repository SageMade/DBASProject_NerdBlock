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
    public partial class ProductInfo : ViewBase
    {
        public ProductInfo()
        {
            InitializeComponent();

            //Input - 5
            Inputs.Add(new TextBoxInput("FirstName", txtProdDesc));
            Inputs.Add(new TextBoxInput("LastName", txtProdHeight));
            Inputs.Add(new TextBoxInput("Phone", txtProdLength));
            Inputs.Add(new TextBoxInput("Email", txtProdName));
            Inputs.Add(new TextBoxInput("SIN", txtProdWidth));

            //Output - 5
            Outputs.Add(new TextBoxOutput("Prod.Desc", txtProdDesc));
            Outputs.Add(new TextBoxOutput("Prod.Height", txtProdHeight));
            Outputs.Add(new TextBoxOutput("Prod.Length", txtProdLength));
            Outputs.Add(new TextBoxOutput("Prod.Name", txtProdName));
            Outputs.Add(new TextBoxOutput("Prod.Width", txtProdWidth));

            //Controls - 1
            btnEdit.Click += (X, Y) => AttemptAction("update_product");

        }
    }
}
