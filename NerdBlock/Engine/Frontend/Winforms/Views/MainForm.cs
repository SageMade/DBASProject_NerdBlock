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
            
            tsiLogin.Visible = true;
            tsiExitProgram.Visible = true;

            __Tie(tsiEmployeeAdd, "goto_employee_add");
            __Tie(tsiEmployeeSearch, "goto_employee_search");

            __Tie(tsiLogin, "goto_login");
            __Tie(tsiLogout, "logout");
            __Tie(tsiExitProgram, "exit_program");

            __Tie(tsiCustomerSearch, "goto_customer_search");

            __Tie(tsiInventorySearch, "goto_inventory_search");
            __Tie(tsiInventoryLostDamaged, "goto_inventory_lost_damaged");
            __Tie(tsiInventoryOverstock, "goto_inventory_overstock");
            __Tie(tsiInventoryAdd, "goto_inventory_add");
            
            __Tie(tsiBlocksAdd, "goto_blocks_add");
            __Tie(tsiBlocksGenres, "goto_blocks_genres");
            __Tie(tsiBlocksQueries, "goto_blocks_queries");
            __Tie(tsiBlocksSeries, "goto_blocks_series");

            __Tie(tsiAddOrder, "goto_order_add");
            __Tie(tsiSearchOrders, "goto_order_search");

            tmrWatch.Tick += (X, Y) => { tslTime.Text = DateTime.Now.ToLongTimeString(); };
            tmrWatch.Start();
        }

        private void __Tie(ToolStripItem tsi, string actionName)
        {
            tsi.Click += (X, Y) => TryAction(actionName);

            ToolStripMapping.Add(tsi, actionName);
        }

        private void TryAction(string name)
        {
            string msg = null;

            if (!LogicManager.TryPerformAction(name, out msg))
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public class ToolStripMap
        {
            public Dictionary<string, ToolStripMapItem> Mapping
            {
                get;
                private set;
            }

            public ToolStripMap()
            {
                Mapping = new Dictionary<string, ToolStripMapItem>();
            }
            
            public void Add(ToolStripItem item, string actionName)
            {
                Mapping.Add(actionName, new ToolStripMapItem(item, actionName));
                item.Visible = false;
            }

            public void VerifyAuth()
            {
                foreach (KeyValuePair<string, ToolStripMapItem> kvp in Mapping)
                {
                    bool isAuthed = Auth.HasAccess(kvp.Value.ActionName);
                    kvp.Value.Control.Available = isAuthed;
                }
            }

            public bool HasEntry(ToolStripItem tsi)
            {
                return Mapping.Values.Count((X) => X.Control == tsi) > 0;
            }

            public class ToolStripMapItem
            {
                public ToolStripItem Control;
                public string ActionName;
                
                public ToolStripMapItem(ToolStripItem control, string actionName)
                {
                    Control = control;
                    ActionName = actionName;
                }

                public static implicit operator ToolStripItem(ToolStripMapItem item)
                {
                    return item.Control;
                }
            }
        }
    }
}
