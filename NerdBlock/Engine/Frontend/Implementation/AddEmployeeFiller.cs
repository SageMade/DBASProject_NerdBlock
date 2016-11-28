using NerdBlock.Frontend.Winforms.Views;
using NerdBlock.Sandbox.Backend.Models;
using NerdBlock.Sandbox.Frontend;
using NerdBlock.Sandbox.Frontend.Winforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Sandbox.Frontend.Implementation
{
    public class AddEmployeeFiller : ViewFillerBase
    {
        public AddEmployee View;

        public AddEmployeeFiller(AddEmployee view)
        {
            AddFiller("FirstName", new TextBoxFiller<Employee>((TextBox)view.Controls["txtFirstName"], "FirstName"));
            AddFiller("LastName", new TextBoxFiller<Employee>((TextBox)view.Controls["txtLastName"], "LastName"));
            //AddFiller("SIN", new TextBoxFiller<Employee>((TextBox)view.Controls["txtSIN"], "SIN"));
        }
    }
}
