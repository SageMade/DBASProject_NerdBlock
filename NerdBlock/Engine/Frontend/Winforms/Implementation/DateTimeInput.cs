using System;
using System.Windows.Forms;

namespace NerdBlock.Engine.Frontend.Winforms.Implementation
{
    /// <summary>
    /// An IInput connector for a datetime picker
    /// </summary>
    public class DateTimeInput : IInput
    {
        private DateTimePicker myControl;

        /// <summary>
        /// Gets or sets the name of the input in the input map
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the value of the input
        /// </summary>
        public object Value
        {
            get { return myControl.Value; }
            set { myControl.Value = value is DateTime ? (DateTime)value : myControl.Value; }
        }

        /// <summary>
        /// Creates a new date time input
        /// </summary>
        /// <param name="valueName">The name of the input in the input map</param>
        /// <param name="input">The control to use as an input</param>
        public DateTimeInput(string valueName, DateTimePicker input)
        {
            Name = valueName;
            myControl = input;
        }
        
        /// <summary>
        /// Fills this IInput from a given IO map
        /// </summary>
        /// <param name="map">The map to fill from</param>
        public void Fill(IoMap map)
        {
            if (map.HasInput(Name))
                Value = map.GetInput<object>(Name);
            else
                myControl.Text = "";
        }

        /// <summary>
        /// Populates an IOMap from this input
        /// </summary>
        /// <param name="map">The map to populate</param>
        public void PopulateMap(IoMap currentMap)
        {
            currentMap.SetInput(Name, myControl.Value);
        }
    }
}
