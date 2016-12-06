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
    public partial class Login : ViewBase
    {
        public Login()
        {
            InitializeComponent();

            Inputs.Add(new TextBoxInput("Employee.Id", txtID));
            Inputs.Add(new TextBoxInput("Employee.Password", txtPassword));

            Outputs.Add(new TextBoxOutput("Employee.Id", txtID));

            btnSubmit.Click += (X, Y) => AttemptAction("login");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
