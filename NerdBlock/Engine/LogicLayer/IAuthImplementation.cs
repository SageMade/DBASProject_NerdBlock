namespace NerdBlock.Engine.LogicLayer
{
    /// <summary>
    /// Represents an implementation of the authorization interface
    /// </summary>
    public interface IAuthImplementation
    {
        /// <summary>
        /// Gets or sets the user object to use for authorization. 
        /// </summary>
        object User { get; set; }

        /// <summary>
        /// Check if the authenticated object has access to an action
        /// </summary>
        /// <param name="actionName">The action name to check</param>
        /// <returns>True if the authenticated user has access to the action</returns>
        bool HasAccess(string actionName);

        /// <summary>
        /// Attempts to perform an action and returns true if it was authorized
        /// </summary>
        /// <param name="actionName">The action to perform</param>
        /// <param name="message">The message returned by the action</param>
        /// <returns>True if the action was performed, false if otherwise</returns>
        bool TryAction(string actionName, out string message);
    }
}
