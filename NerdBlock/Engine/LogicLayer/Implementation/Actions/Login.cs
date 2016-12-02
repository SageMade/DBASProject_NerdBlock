using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using NerdBlock.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    [BusinessActionContainer]
    public class LoginActions
    {
        [BusinessAction("login")]
        public void Login()
        {
            Employee auth = DataAccess.SelectAll<Employee>().First();

            Session.Set("Auth.Employee", auth);

            ViewManager.InitAuth(auth.Role);

            Context.Values["Series"] = DataAccess.Execute(Resources.SelectGenreTalliesQuery);
            ViewManager.Show("BlockGenres");
        }

        [BusinessAction("goto_login")]
        public void ShowLogin()
        {
            ViewManager.Show("Login");
        }
    }
}
