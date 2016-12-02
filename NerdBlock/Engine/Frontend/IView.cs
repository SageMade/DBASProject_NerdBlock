namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents a view that displays data
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Shows this view
        /// </summary>
        void ShowView();

        /// <summary>
        /// Handles loading the ouptu fields into the view if applicable
        /// </summary>
        void LoadView();
    }
}
