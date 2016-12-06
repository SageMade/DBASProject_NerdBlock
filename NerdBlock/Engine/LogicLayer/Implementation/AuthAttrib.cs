using System;

namespace NerdBlock.Engine.LogicLayer.Implementation
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
        /// Gets or sets whether unauthorized users can access the item
        /// </summary>
        public bool AllowNull
        {
            get; set;
        }

        /// <summary>
        /// Creates a new authorization attribute
        /// </summary>
        /// <param name="roleNames">The roles that have access to this view</param>
        public AuthAttrib(params string[] roleNames)
        {
            AllowNull = false;
            RoleNames = roleNames;
        }

        /// <summary>
        /// Creates a new authorization attribute
        /// </summary>
        /// <param name="allowNull">True if unauthorized users can access the item</param>
        /// <param name="roleNames">The roles that have access to this view</param>
        public AuthAttrib(bool allowNull, params string[] roleNames)
        {
            AllowNull = allowNull;
            RoleNames = roleNames;
        }
    }
}
