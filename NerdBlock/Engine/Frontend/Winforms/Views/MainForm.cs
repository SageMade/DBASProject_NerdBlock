using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
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
        public ToolStripMap ToolStripMapping
        {
            get;
            private set;
        }

        public MainForm()
        {
            ToolStripMapping = new ToolStripMap();

            InitializeComponent();

            ToolStripMapping.Add<AddEmployee>(tsiEmployeeAdd);
            ToolStripMapping.Add<EmployeeSearch>(tsiEmployeeAdd);

            tsiLogin.Visible = true;
            tsiExitProgram.Visible = true;

            tsiEmployeeAdd.Click += (X, Y) => TryAction("goto_employee_add");
            tsiEmployeeSearch.Click += (X, Y) => TryAction("goto_employee_search");
            tsiLogin.Click += (X, Y) => TryAction("goto_login");
            tsiCustomerSearch.Click += (X, Y) => TryAction("goto_customer_search");
            tsiInventorySearch.Click += (X, Y) => TryAction("goto_inventory_search");
            tsiInventoryLostDamaged.Click += (X, Y) => TryAction("goto_inventory_lost_damaged");
            tsiInventoryOverstock.Click += (X, Y) => TryAction("goto_inventory_overstock");
            tsiBlocksAdd.Click += (X, Y) => TryAction("goto_blocks_add");
            tsiBlocksGenres.Click += (X, Y) => TryAction("goto_blocks_genres");
            tsiBlocksQueries.Click += (X, Y) => TryAction("goto_blocks_queries");
            tsiBlocksSeries.Click += (X, Y) => TryAction("goto_blocks_series");
        }

        private void TryAction(string name)
        {
            string msg = null;

            if (!LogicManager.TryPerformAction(name, out msg))
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public class ToolStripMap
        {
            public Dictionary<string, ToolStripItem> Mapping
            {
                get;
                private set;
            }

            public ToolStripMap()
            {
                Mapping = new Dictionary<string, ToolStripItem>();
            }

            public void Add<T>(ToolStripItem item)
            {
                Mapping.Add(typeof(T).Name, item);
                item.Visible = false;
            }

            public void Add(string viewName, ToolStripItem item)
            {
                Mapping.Add(viewName, item);
                item.Visible = false;
            }
        }
    }
}
