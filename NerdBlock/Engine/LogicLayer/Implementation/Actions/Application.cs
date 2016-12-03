using NerdBlock.Engine.Frontend;

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
        public void Exit()
        {
            ViewManager.CloseProgram();
        }
    }
}
