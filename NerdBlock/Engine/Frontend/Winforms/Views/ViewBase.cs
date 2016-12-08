using NerdBlock.Engine.LogicLayer;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.ComponentModel;
using NerdBlock.Engine.Frontend.Winforms.Implementation;

namespace NerdBlock.Engine.Frontend.Winforms.Views
{
    /// <summary>
    /// The base class for all our winforms views
    /// </summary>
    public class ViewBase : UserControl, IView
    {
        [Browsable(true)]
        public override Color BackColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the list of Input elements for this view. These are items that
        /// provide an input to the IoMap
        /// </summary>
        protected virtual NamedCollection<IInput> Inputs
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the list of Output elements for this view. These are items that
        /// display a value from the IoMap
        /// </summary>
        protected virtual NamedCollection<IOutput> Outputs
        {
            get;
            set;
        }

        /// <summary>
        /// Default constructor for ViewBase
        /// </summary>
        public ViewBase()
        {
            Inputs = new NamedCollection<IInput>();
            Outputs = new NamedCollection<IOutput>();

            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
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

            // Iterate over outputs and fill them from the map
            for (int index = 0; index < Outputs.Count; index++)
                Outputs[index].Fill(map);

            // Iterate over inputs and fill them from the map
            for (int index = 0; index < Inputs.Count; index++)
                Inputs[index].Fill(map);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Brush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, 0, 0, Width, Height);
            
            base.OnPaint(e);
        }

        protected virtual void BeforeSubmit(IoMap map) { }

        /// <summary>
        /// Attempts an action from this view, handles loading inputs into IoMap
        /// </summary>
        /// <param name="actionName">The name of the action to perform</param>
        public void AttemptAction(string actionName)
        {
            // Iterate over our inputs and populate the IO map from them
            for(int index = 0; index < Inputs.Count; index ++)
                Inputs[index].PopulateMap(ViewManager.CurrentMap);

            // Call our child's method
            BeforeSubmit(ViewManager.CurrentMap);

            // Let the logic manager do the heavy lifting
            LogicManager.TryPerformAction(actionName);
        }

        protected override void OnRegionChanged(EventArgs e)
        {
            if (Top < 0)
                Top = 0;
            if (Left < 0)
                Left = 0;

            Parent?.PerformLayout();

            base.OnRegionChanged(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ViewBase
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ViewBase";
            this.ResumeLayout(false);

        }
    }
}
