using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using NerdBlock.Properties;
using System.Linq;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Stores actions related to authentication
    /// </summary>
    [BusinessActionContainer]
    public class LoginActions
    {
        /// <summary>
        /// Handles logging into the application
        /// </summary>
        [BusinessAction("login")]
        public void Login()
        {
            Employee auth = DataAccess.SelectAll<Employee>().First();

            Session.Set("Auth.Employee", auth);

            ViewManager.InitAuth(auth.Role);

            Context.Values["Series"] = DataAccess.Execute(Resources.SelectGenreTalliesQuery);
            ViewManager.Show("BlockGenres");
        }

        /// <summary>
        /// Handles going to the login view
        /// </summary>
        [BusinessAction("goto_login")]
        public void ShowLogin()
        {
            ViewManager.Show("Login");
        }
    }
}
