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
            
            Inputs.Add(new TextBoxInput("Company.Name", txtCompany));
            Inputs.Add(new TextBoxInput("Company.Phone", txtPhone));

            Inputs.Add(new TextBoxInput("Contact.FirstName", txtFirst));
            Inputs.Add(new TextBoxInput("Contact.LastName", txtLast));
            Inputs.Add(new TextBoxInput("Contact.Email", txtEmail));

            btnAdd.Click += (X, Y) => AttemptAction("insert_supplier");
        }

        protected override void LoadMyViewContext(IoMap map)
        {
            adrInCompany.Fill(map);
        }

        protected override void BeforeSubmit(IoMap map)
        {
            adrInCompany.Populate(map);
        }
    }
}
