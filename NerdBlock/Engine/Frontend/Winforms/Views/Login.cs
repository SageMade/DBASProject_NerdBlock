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

            btnSubmit.Click += (X, Y) => AttemptAction("login");
        }        
    }
}
