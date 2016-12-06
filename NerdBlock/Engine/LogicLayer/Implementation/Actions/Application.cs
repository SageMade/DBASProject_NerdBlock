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
            IoMap map = ViewManager.CurrentMap;

            if (int.TryParse(map.GetInput<string>("Employee.Id"), out emplId))
            {
                Employee auth = new Employee();
                auth.EmployeeId = int.Parse(map.GetInput<string>("Employee.Id"));

                Employee match = DataAccess.FromPrimaryKey<Employee>(emplId);

                if (match != null && PasswordSecurity.PasswordStorage.VerifyPassword(map.GetInput<string>("Employee.Password"), match.HashedPassword))
                {
                    Auth.User = match;
                    LogicManager.TryPerformAction("goto_blocks_genres");
                }
                else
                {
                    map.Reset();
                    map.SetInput("Employee.Id", emplId);
                    ViewManager.ShowFlash("Invalid credentials", FlashMessageType.Bad);
                    ViewManager.Show("Login", map);
                }
            }
            else
            {
                map.Reset();
                ViewManager.ShowFlash("Please enter your employee ID", FlashMessageType.Bad);
                ViewManager.Show("Login", map);
            }
        }

        /// <summary>
        /// Handles going to the login view
        /// </summary>
        [BusinessAction("goto_login")]
        [AuthAttrib(true, "*")]
        public void ShowLogin()
        {
            ViewManager.CurrentMap.Reset();
            ViewManager.Show("Login");
        }

        [BusinessAction("goto_password_change")]
        [AuthAttrib("*")]
        public void ShowPasswordChange()
        {
            ViewManager.CurrentMap.Reset();
            ViewManager.Show("UpdatePassword");
        }

        [BusinessAction("change_password")]
        [AuthAttrib("*")]
        public void ChangePassword()
        {
            IoMap map = ViewManager.CurrentMap;

            if (map.HasInput<string>("OldPassword"))
            {
                string oldPass = map.GetInput<string>("OldPassword");

                if (map.HasInput<string>("NewPassword"))
                {
                    string newPass = map.GetInput<string>("NewPassword");
                    if (map.HasInput<string>("ConfirmPassword"))
                    {
                        string confirmPass = map.GetInput<string>("ConfirmPassword");

                        if (PasswordSecurity.PasswordStorage.VerifyPassword(oldPass, (Auth.User as Employee).HashedPassword))
                        {
                            if (newPass.Equals(confirmPass))
                            {
                                Employee auth = (Auth.User as Employee);
                                auth.HashedPassword = PasswordSecurity.PasswordStorage.CreateHash(newPass);
                                DataAccess.Update(auth);

                                Auth.User = auth;
                                ViewManager.ShowFlash("Password has been updated!", FlashMessageType.Good);
                                ViewManager.GotoPrevious();
                                return;
                            }
                            else
                            {
                                ViewManager.ShowFlash("New password and confirm password do not match", FlashMessageType.Bad);
                                ViewManager.Show("UpdatePassword");
                                return;
                            }
                        }
                        else
                        {
                            ViewManager.ShowFlash("Old Password does not match", FlashMessageType.Bad);
                            ViewManager.Show("UpdatePassword");
                            return;
                        }
                    }
                }
            }

            ViewManager.ShowFlash("Not enough input for action", FlashMessageType.Bad);
        }
                
        [BusinessAction("go_back")]
        [AuthAttrib(true, "*")]
        public void GoBack()
        {
            ViewManager.GotoPrevious();
        }
        /// <summary>
        /// Handles logging into the application
        /// </summary>
        [BusinessAction("logout")]
        [AuthAttrib(true, "*")]
        public void Logout()
        {
            Auth.User = null;
            ViewManager.CurrentMap.Reset();
            ViewManager.Show("Login");
        }
    }
}
