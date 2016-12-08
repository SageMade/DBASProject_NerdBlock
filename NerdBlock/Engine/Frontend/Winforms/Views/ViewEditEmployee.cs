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
    public partial class ViewEditEmployee : ViewBase
    {
        public ViewEditEmployee()
        {
            InitializeComponent();

            Inputs.Add(new TextBoxInput(      "Employee.FirstName", txtFirstName));
            Inputs.Add(new TextBoxInput(      "Employee.LastName", txtLastName));
            Inputs.Add(new TextBoxInput(      "Employee.Phone", txtPhone));
            Inputs.Add(new TextBoxInput(      "Employee.Email", txtEmail));
            Inputs.Add(new TextBoxInput(      "Employee.SIN", txtSIN));
            Inputs.Add(new ComboBoxValueInput("Employee.Role", cbRole));

            Inputs.Add(new TextBoxInput(     "Address.Street", txtStreet));
            Inputs.Add(new ComboBoxTextInput("Address.Country", cbCountry));
            Inputs.Add(new ComboBoxTextInput("Address.State", cbState));
            Inputs.Add(new ComboBoxTextInput("Address.City", cbCity));
            Inputs.Add(new TextBoxInput(     "Address.PostalCode", txtPostalCode));
            Inputs.Add(new TextBoxInput(     "Address.AptNum", txtAptNum));

            ViewManager.PopulateList<EmployeeRole, ComboBox>(cbRole);
            ViewManager.PopulateFromQuery(cbState, DataAccess.Execute("select state from tbladdress group by state order by state"));
            ViewManager.PopulateFromQuery(cbCountry, DataAccess.Execute("select country from tbladdress group by country order by country"));
            ViewManager.PopulateFromQuery(cbCity, DataAccess.Execute("select city from tbladdress group by city order by city"));
            
            btnEdit.Click += (X, Y) => AttemptAction("update_employee");
            btnTerminate.Click += (X, Y) => AttemptAction("terminate_employee");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void LoadMyViewContext(IoMap map)
        {
            //Pulling from the session
            Employee instance = map.GetInput<Employee>("Employee.Info");

            if (instance != null)
            {
                //Setting the inputs on load
                map.SetInput("Employee.FirstName", instance.FirstName);
                map.SetInput("Employee.LastName", instance.LastName);
                map.SetInput("Employee.Email", instance.Email);
                map.SetInput("Employee.Phone", instance.Phone);
                map.SetInput("Employee.SIN", instance.SIN);
                map.SetInput("Employee.Role", instance.Role);

                map.SetInput("Address.Street", instance.HomeAddress.StreetAddress);
                map.SetInput("Address.Country", instance.HomeAddress.Country);
                map.SetInput("Address.State", instance.HomeAddress.State);
                map.SetInput("Address.City", instance.HomeAddress.City);
                map.SetInput("Address.PostalCode", instance.HomeAddress.PostalCode);
                map.SetInput("Address.AptNum", instance.HomeAddress.ApartmentNumber);

                map.SetInput("Employee", instance);
                map.SetInput<Employee>("Employee.Info", null);
            }

        }
    }
}
