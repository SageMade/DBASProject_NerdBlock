using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

/// <summary>
/// This page might be redesigned to add a 'Subscriptions' button that opens a form with all the subscriptions pane information, instead of having
/// it on the same form.
/// </summary>
namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class CustomerInfo : ViewBase
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {
            //Outputs - 9 
            Outputs.Add(new LabelOutput("Cust.ID", lblID));
            Outputs.Add(new LabelOutput("Cust.Email", lblEmail));
            Outputs.Add(new LabelOutput("Cust.FirstName", lblFirstName));
            Outputs.Add(new LabelOutput("Cust.HomeAddr", lblHomeAddr));
            Outputs.Add(new LabelOutput("Cust.JoinDate", lblJoined));
            Outputs.Add(new LabelOutput("Cust.LastName", lblLastName));
            Outputs.Add(new LabelOutput("Cust.ShipAddr", lblShipAdd));
            Outputs.Add(new LabelOutput("Cust.Username", lblUserName));
            Outputs.Add(new DataGridOutput("ActiveSubs", dgvActiveSubs));

        }
    }
}
