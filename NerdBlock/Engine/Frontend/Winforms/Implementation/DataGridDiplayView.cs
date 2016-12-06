using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    public class DataGridDisplayView : DataGridView
    {
        public DataGridDisplayView() : base()
        {
            RowHeadersVisible = false;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            ReadOnly = true;
            AutoGenerateColumns = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
