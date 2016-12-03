namespace NerdBlock.Engine.LogicLayer
{
    /// <summary>
    /// Represents a business rule that effects whether or not actions can be performed
    /// </summary>
    public abstract class BusinessRule
    {
        /// <summary>
        /// Gets or sets the debug name for this rule
        /// </summary>
        public virtual string DebugName { get; protected set; }

        /// <summary>
        /// Checks whether this rule allows or disallows an action to be performed. This
        /// is where things like validation can be performed
        /// </summary>
        /// <param name="actionName">The name of the action to check</param>
        /// <param name="reason">The reference to a string that will store the failure reason if applicable</param>
        /// <returns>True if the action can be performed, false if otherwise</returns>
        public abstract bool CanPerform(string actionName, ref string reason);
    }
}
