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
            int emplId = -1;

            if (int.TryParse(Context.GetValue<string>("Employee.Id"), out emplId))
            {
                Employee auth = new Employee();
                auth.EmployeeId = int.Parse(Context.GetValue<string>("Employee.Id"));

                Employee match = DataAccess.FromPrimaryKey<Employee>(emplId);

                if (match != null && PasswordSecurity.PasswordStorage.VerifyPassword(Context.GetValue<string>("Employee.Password"), match.HashedPassword))
                {
                    Auth.User = match;
                    LogicManager.TryPerformAction("goto_blocks_genres");
                }
                else
                {
                    Context.SetValue("Employee.Id", emplId.ToString());
                    Context.SetValue("Employee.Password", "");
                    ViewManager.ShowFlash("Invalid credentials", FlashMessageType.Bad);
                    ViewManager.Show("Login");
                }
            }
            else
            {
                Context.SetValue("Employee.Id", "");
                Context.SetValue("Employee.Password", "");
                ViewManager.ShowFlash("Please enter your employee ID", FlashMessageType.Bad);
                ViewManager.Show("Login");
            }
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
