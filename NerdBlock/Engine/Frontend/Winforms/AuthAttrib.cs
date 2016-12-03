using System;

namespace NerdBlock.Engine.Frontend.Winforms
{
    /// <summary>
    /// An attribute that marks a view as visible to authorized roles
    /// </summary>
    public class AuthAttrib : Attribute
    {
        /// <summary>
        /// Gets the list of role names that have access to the view
        /// </summary>
        public string[] RoleNames
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new authorization attribute
        /// </summary>
        /// <param name="roleNames">The roles that have access to this view</param>
        public AuthAttrib(params string[] roleNames)
        {
            RoleNames = roleNames;
        }
    }
}
