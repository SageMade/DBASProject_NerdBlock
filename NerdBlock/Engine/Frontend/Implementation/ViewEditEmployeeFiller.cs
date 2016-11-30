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
    public class ViewEditEmployeeFiller : ViewFillerBase
    {
        public ViewEditEmployee View;

        public ViewEditEmployeeFiller(ViewEditEmployee view)
        {
            AddFiller("EmployeeID", new LabelFiller<Employee>((Label)view.Controls["lblEmployeeID"], "EmployeeID"));
            AddFiller("SIN", new LabelFiller<Employee>((Label)view.Controls["txtSIN"], "SIN"));
            AddFiller("FirstName", new LabelFiller<Employee>((Label)view.Controls["txtFirstName"], "FirstName"));
            AddFiller("LastName", new LabelFiller<Employee>((Label)view.Controls["txtLastName"], "LastName"));
            AddFiller("Phone", new LabelFiller<Employee>((Label)view.Controls["txtPhone"], "Phone"));
        }
    }
}
