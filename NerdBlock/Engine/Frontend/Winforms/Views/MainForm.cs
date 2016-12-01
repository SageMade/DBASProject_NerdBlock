using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend.Implementation;
using NerdBlock.Engine.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class MainForm : Form
    {

        public MainForm()
        {

            InitializeComponent();

            tsiEmployeeAdd.Click += (X, Y) => TryAction("goto_employee_add");
            tsiEmployeeSearch.Click += (X, Y) => TryAction("goto_employee_search");
            tsiEmployeeUpdate.Click += (X, Y) => TryAction("goto_employee_update");
            tsiLogin.Click += (X, Y) => TryAction("goto_login");
            tsiCustomerSearch.Click += (X, Y) => TryAction("goto_customer_search");
            tsiInventorySearch.Click += (X, Y) => TryAction("goto_inventory_search");
            tsiInventoryUpdate.Click += (X, Y) => TryAction("goto_inventory_update");
            tsiInventoryLostDamaged.Click += (X, Y) => TryAction("goto_inventory_lost_damaged");
            tsiInventoryOverstock.Click += (X, Y) => TryAction("goto_inventory_overstock");
        }

        private void TryAction(string name)
        {
            string msg = null;

            if (!LogicManager.TryPerformAction(name, out msg))
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
