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

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class AddEmployee : ViewBase
    {
        public AddEmployee()
        {
            InitializeComponent();

            Inputs.Add(new ReflectedInput("FirstName", txtFirstName, "Text"));
            Inputs.Add(new ReflectedInput("LastName", txtLastName, "Text"));
            Inputs.Add(new ReflectedInput("SIN", txtCell, "Text"));
            Inputs.Add(new ReflectedInput("Phone", txtPhone, "Text"));

            btnSubmit.Click += (X, Y) => AttemptAction("insert_employee");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
