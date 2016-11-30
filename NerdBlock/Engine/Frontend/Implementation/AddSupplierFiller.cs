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
     public class AddSupplierFiller : ViewFillerBase
    {
        public AddSupplier View;

        public AddSupplierFiller(AddSupplier view)
        {
            AddFiller("SupplierID", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtContact"], "SupplierID"));
            AddFiller("Company", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtCompany"], "Company"));
            AddFiller("Phone", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtPhone"], "Phone"));
            AddFiller("FirstName", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtFirstName"], "FirstName"));
            AddFiller("LastName", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtLastName"], "LastName"));
            AddFiller("Email", new TextBoxFiller<Supplier>((TextBox)view.Controls["txtSupplier"], "Email"));
        }
    }
}
