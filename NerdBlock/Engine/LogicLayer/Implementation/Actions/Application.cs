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
            Employee auth = new Employee();
            auth.EmployeeId = Context.GetValue<int>("Emnployee.Id");

            Employee[] match = DataAccess.Match(auth);

            if (match.Length > 0 && PasswordSecurity.PasswordStorage.VerifyPassword(Context.GetValue<string>("Employee.Password"), match[0].HashedPassword))
            {
                Auth.User = match[0];
                LogicManager.TryPerformAction("goto_blocks_genres");
            }
            else
                ViewManager.ShowFlash("Invalid credentials", FlashMessageType.Bad);
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
