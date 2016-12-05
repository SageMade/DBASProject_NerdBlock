using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class EmployeeSearch : ViewBase
    {
        public EmployeeSearch()
        {
            InitializeComponent();

            // Add inputs
            Inputs.Add(new TextBoxInput("ID", txtEmployeeID));

            // Add outputs
            Outputs.Add(new DataGridOutput("AllEmployees", dgvEmployeeList));
        }
    }
}
