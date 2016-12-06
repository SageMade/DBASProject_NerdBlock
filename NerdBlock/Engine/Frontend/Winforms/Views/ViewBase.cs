using NerdBlock.Engine.LogicLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    /// <summary>
    /// The base class for all our winforms views
    /// </summary>
    public class ViewBase : UserControl, IView
    {
        /// <summary>
        /// Gets the list of Input elements for this view. These are items that
        /// provide an input to the IoMap
        /// </summary>
        protected virtual List<IInput> Inputs
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the list of Output elements for this view. These are items that
        /// display a value from the IoMap
        /// </summary>
        protected virtual List<IOutput> Outputs
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor for ViewBase
        /// </summary>
        public ViewBase()
        {
            Inputs = new List<IInput>();
            Outputs = new List<IOutput>();
        }

        /// <summary>
        /// Called in LoadView before Inputs and Outputs are filled
        /// </summary>
        /// <param name="map">The IoMap to load the view with</param>
        protected virtual void LoadMyViewContext(IoMap map) { }

        /// <summary>
        /// Loads this view with the given IoMap
        /// </summary>
        /// <param name="map">The IoMap to load the view with</param>
        public void LoadView(IoMap map)
        {
            // Let child classes hook into our loadview
            LoadMyViewContext(map);

            // Iterate over inputs and fill them from the map
            for (int index = 0; index < Inputs.Count; index++)
                Inputs[index].Fill(map);

            // Iterate over outputs and fill them from the map
            for (int index = 0; index < Outputs.Count; index++)
                Outputs[index].Fill(map);
        }

        /// <summary>
        /// Attempts an action from this view, handles loading inputs into IoMap
        /// </summary>
        /// <param name="actionName">The name of the action to perform</param>
        public void AttemptAction(string actionName)
        {
            // Iterate over our inputs and populate the IO map from them
            for(int index = 0; index < Inputs.Count; index ++)
                Inputs[index].PopulateMap(ViewManager.CurrentMap);

            // Let the logic manager do the heavy lifting
            LogicManager.TryPerformAction(actionName);
        }
    }
}
