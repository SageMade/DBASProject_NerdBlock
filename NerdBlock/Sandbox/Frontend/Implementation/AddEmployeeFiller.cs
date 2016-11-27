using NerdBlock.Sandbox.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Frontend.Implementation
{
    public class AddEmployeeFiller : ViewFiller<Employee>
    {
        public AddEmployee View;

        public void Fill(Employee value)
        {
            if (value != null)
            {
                View.Controls["txtID"].Text = value.ID.ToString();
                View.Controls["txtFirstName"].Text = value.FirstName;
                View.Controls["txtLastName"].Text = value.LastName;

                View.Controls["txtPhone"].Text = value.Phone?.ToString();

                View.Controls["txtAddress1"].Text = value.Address.StreetAddress;
                View.Controls["txtProvince"].Text = value.Address.State;
                View.Controls["txtPostalCode"].Text = value.Address.PostalCode;
            }
        }
    }
}
