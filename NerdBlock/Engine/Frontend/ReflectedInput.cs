using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        public ReflectedInput(string name, object container, string propertyName)
        {
            Name = name;
            myContainer = container;
            myReflectedProperty = container.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
        }
    }
}
