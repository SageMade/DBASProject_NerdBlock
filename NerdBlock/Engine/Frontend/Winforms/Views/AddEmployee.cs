﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NerdBlock.Engine.Frontend.Winforms.Views;
using NerdBlock.Engine.Frontend.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    public partial class AddEmployee : ViewBase
    {
        public AddEmployee()
        {
            InitializeComponent();

            Inputs.Add(new TextBoxInput("FirstName", txtFirstName));
            Inputs.Add(new TextBoxInput("LastName", txtLastName));
            //Inputs.Add(new TextBoxInput("SIN", txtSIN));
            Inputs.Add(new TextBoxInput("Phone", txtPhone));

            btnSubmit.Click += (X, Y) => AttemptAction("insert_employee");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
