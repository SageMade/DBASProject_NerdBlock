using NerdBlock.Sandbox.Backend;
using NerdBlock.Sandbox.Backend.Models;
using NerdBlock.Sandbox.Frontend.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerdBlock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AddEmployeeFiller filler = new AddEmployeeFiller();
            filler.View = addEmployee1;

            Employee search = new Employee() { FirstName = "Shawn", LastName = "Matthews" };

            Employee[] results = DataAccess.Match(search);
            
            filler.Fill(results[0]);
        }
    }
}
