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
    public partial class AddEmployee : ViewBase
    {
        public AddEmployee()
        {
            InitializeComponent();

            Inputs.Add(new TextBoxInput("FirstName", txtFirstName));
            Inputs.Add(new TextBoxInput("LastName", txtLastName));
            Inputs.Add(new TextBoxInput("Phone", txtPhone));
            Inputs.Add(new TextBoxInput("Email", txtEmail));
            Inputs.Add(new TextBoxInput("SIN", txtSIN));
            Inputs.Add(new ComboBoxValueInput("Role", cbRole));
            Inputs.Add(new TextBoxInput("Address.StreetAddress", txtStreet));
            Inputs.Add(new TextBoxInput("Address.Country", txtCountry));
            Inputs.Add(new ComboBoxTextInput("Address.State", cbState));
            Inputs.Add(new TextBoxInput("Address.City", txtCity));
            Inputs.Add(new TextBoxInput("Address.PostalCode", txtPostalCode));
            Inputs.Add(new TextBoxInput("Address.AptNum", txtAptNum));
            Inputs.Add(new TextBoxInput("FooBar", txtFooBar));

            ViewManager.PopulateList<EmployeeRole, ComboBox>(cbRole);
            ViewManager.PopulateFromQuery(cbState, DataAccess.Execute("select state from tbladdress group by state order by state"));

            btnSubmit.Click += (X, Y) => AttemptAction("insert_employee");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
