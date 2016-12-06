using NerdBlock.Engine.LogicLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    /// <summary>
    /// The main form for the application
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets the toolstrip mapping for the form
        /// </summary>
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
            __Tie(tsiChangePassword, "goto_password_change");
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

        /// <summary>
        /// Ties together a toolstrip item and an action
        /// </summary>
        /// <param name="tsi">The toolstrip item to tie</param>
        /// <param name="actionName">The action that this item is associated with</param>
        private void __Tie(ToolStripItem tsi, string actionName)
        {
            tsi.Click += (X, Y) => TryAction(actionName);

            ToolStripMapping.Add(tsi, actionName);
        }

        /// <summary>
        /// Attempts an action with the given name, and shows a message on failure
        /// </summary>
        /// <param name="name">The name of the action to perform</param>
        private void TryAction(string name)
        {
            string msg = null;

            if (!LogicManager.TryPerformAction(name, out msg))
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        /// <summary>
        /// Represents the mapping of toolstrip items to their respective actions
        /// </summary>
        public class ToolStripMap
        {
            /// <summary>
            /// Gets the mapping dictionary
            /// </summary>
            public Dictionary<string, ToolStripMapItem> Mapping
            {
                get;
                private set;
            }

            /// <summary>
            /// Creates a new toolstrip map
            /// </summary>
            public ToolStripMap()
            {
                Mapping = new Dictionary<string, ToolStripMapItem>();
            }
            
            /// <summary>
            /// Adds an item to the map
            /// </summary>
            /// <param name="item">The toolstrip item to add</param>
            /// <param name="actionName">The action that the item relates to</param>
            public void Add(ToolStripItem item, string actionName)
            {
                Mapping.Add(actionName, new ToolStripMapItem(item, actionName));
                item.Visible = false;
            }

            /// <summary>
            /// Handles using the Auth engine to enable or disable toolstrip items
            /// depending on whether or not the user can access them
            /// </summary>
            public void VerifyAuth()
            {
                foreach (KeyValuePair<string, ToolStripMapItem> kvp in Mapping)
                {
                    bool isAuthed = Auth.HasAccess(kvp.Value.ActionName);
                    kvp.Value.Control.Available = isAuthed;
                }
            }

            /// <summary>
            /// Checks to see if there is an entry for the given toolstrip item
            /// </summary>
            /// <param name="tsi">The item to search for</param>
            /// <returns>True of there is an entry for <i>tis</i>, false if otherwise</returns>
            public bool HasEntry(ToolStripItem tsi)
            {
                return Mapping.Values.Count((X) => X.Control == tsi) > 0;
            }

            /// <summary>
            /// Represents a single item in the toolstrip map
            /// </summary>
            public class ToolStripMapItem
            {
                /// <summary>
                /// Gets or sets the toolstrip item control
                /// </summary>
                public ToolStripItem Control;
                /// <summary>
                /// Gets or sets the action that the item is associated with
                /// </summary>
                public string ActionName;
                
                /// <summary>
                /// Create a new toolstrip map item
                /// </summary>
                /// <param name="control">The toolstrip item control</param>
                /// <param name="actionName">The action that the item is associated with</param>
                public ToolStripMapItem(ToolStripItem control, string actionName)
                {
                    Control = control;
                    ActionName = actionName;
                }

                /// <summary>
                /// Handles casting a toolstrip map item to it's underlying toolstrip control
                /// </summary>
                /// <param name="item">The item to cast</param>
                public static implicit operator ToolStripItem(ToolStripMapItem item)
                {
                    return item.Control;
                }
            }
        }
    }
}
