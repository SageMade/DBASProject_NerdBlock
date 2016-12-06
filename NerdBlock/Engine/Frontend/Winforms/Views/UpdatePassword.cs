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
    public partial class UpdatePassword : ViewBase
    {
        public UpdatePassword()
        {
            InitializeComponent();

            Inputs.Add(new TextBoxInput("OldPassword", txtCurrentPassword));
            Inputs.Add(new TextBoxInput("NewPassword", txtNewPassword));
            Inputs.Add(new TextBoxInput("ConfirmPassword", txtPasswordConfirm));

            btnUpdate.Click += (X, Y) => AttemptAction("change_password");
            btnCancel.Click += (X, Y) => AttemptAction("go_back");
        }
    }
}
