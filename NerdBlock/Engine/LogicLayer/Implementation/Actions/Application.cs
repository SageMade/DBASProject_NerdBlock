using NerdBlock.Engine.Backend;
using NerdBlock.Engine.Backend.Models;
using NerdBlock.Engine.Frontend;
using NerdBlock.Properties;
using System.Linq;

namespace NerdBlock.Engine.LogicLayer.Implementation.Actions
{
    /// <summary>
    /// Represents the actions relating to the main Application logic
    /// </summary>
    [BusinessActionContainer]
    public class Application
    {
        /// <summary>
        /// Handles exiting the application
        /// </summary>
        [BusinessAction("exit_program")]
        [AuthAttrib(true, "*")]
        public void Exit()
        {
            ViewManager.CloseProgram();
        }

        /// <summary>
        /// Handles logging into the application
        /// </summary>
        [BusinessAction("login")]
        [AuthAttrib(true, "*")]
        public void Login()
        {
            Employee auth = DataAccess.SelectAll<Employee>().First();
            Auth.User = auth;

            LogicManager.TryPerformAction("goto_blocks_genres");
        }

        /// <summary>
        /// Handles going to the login view
        /// </summary>
        [BusinessAction("goto_login")]
        [AuthAttrib(true, "*")]
        public void ShowLogin()
        {
            ViewManager.Show("Login");
        }

        /// <summary>
        /// Handles logging into the application
        /// </summary>
        [BusinessAction("logout")]
        [AuthAttrib(true, "*")]
        public void Logout()
        {
            Auth.User = null;

            ViewManager.ShowInitial();
            
            ViewManager.Show("Login");
        }
    }
}
