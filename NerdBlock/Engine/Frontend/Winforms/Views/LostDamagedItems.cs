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
    public partial class LostDamagedItems : ViewBase
    {
        public LostDamagedItems()
        {
            InitializeComponent();

            //Output - 1
            Outputs.Add(new DataGridOutput("DmgInventory", dgvDmgInventory));

            //Control - 2 to add



        }
    }
}
