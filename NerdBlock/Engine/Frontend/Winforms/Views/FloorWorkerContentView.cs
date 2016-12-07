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

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class FloorWorkerContentView : ViewBase
    {
        public FloorWorkerContentView()
        {
            InitializeComponent();

            //Outputs - 1 DONE
            Outputs.Add(new DataGridOutput("Inventory", dgvInventory));

            //Controls - 1 DONE
            btnViewProduct.Click += (X, Y) =>
            {
                ViewManager.CurrentMap.SetInput("TargetItem", dgvInventory.SelectedRows[0]);
                AttemptAction("goto_view_products");
            };

        }
    }
}
