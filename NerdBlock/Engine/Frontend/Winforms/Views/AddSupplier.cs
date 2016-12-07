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
    public partial class AddSupplier : ViewBase
    {
        public AddSupplier()
        {
            InitializeComponent();

            Inputs.Add(new TextBoxInput("ContactId", txtContact));
            Inputs.Add(new TextBoxInput("Company", txtCompany));
            Inputs.Add(new TextBoxInput("Phone", txtPhone));
            Inputs.Add(new TextBoxInput("FirstName", txtFirst));
            Inputs.Add(new TextBoxInput("LastName", txtLast));
            Inputs.Add(new TextBoxInput("Email", txtEmail));

            btnAdd.Click += (X, Y) => AttemptAction("insert_supplier");
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
