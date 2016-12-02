using System.Reflection;

namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents an implementation of the IInput interface that uses reflection to get a value
    /// </summary>
    public class ReflectedInput : IInput
    {
        PropertyInfo myReflectedProperty;
        object myContainer;

        /// <summary>
        /// Gets or sets this inputs name
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Get's this inputs value
        /// </summary>
        public object Value
        {
            get {
                return myContainer == null ? null :
                    myReflectedProperty == null ? null :
                        myReflectedProperty.GetValue(myContainer);
            }
        }

        /// <summary>
        /// Creates a new reflected input with the given name, object and a property name
        /// </summary>
        /// <param name="name">The name of the input in the input map</param>
        /// <param name="container">The containing object to get the input vlaue from</param>
        /// <param name="propertyName">The name of the property within the object to get</param>
        public ReflectedInput(string name, object container, string propertyName)
        {
            Name = name;
            myContainer = container;
            myReflectedProperty = container.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
        }
    }
}
