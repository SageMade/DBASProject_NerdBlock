using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using NerdBlock.Engine.Frontend.Winforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Implementation
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
