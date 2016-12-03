using System;

namespace NerdBlock.Engine.LogicLayer
{
    /// <summary>
    /// An attribute that marks a method as a business action for the
    /// runtime type collector
    /// </summary>
    public class BusinessAction : Attribute
    {
        /// <summary>
        /// Gets or sets the name to register tha action as
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Creates a new action attribute with the given attribute name
        /// </summary>    
        public BusinessAction(string name) { Name = name; }
    }

    /// <summary>
    /// An attribute that marks a class as one that contains business actions
    /// </summary>
    public class BusinessActionContainer : Attribute
    {
    }
}
