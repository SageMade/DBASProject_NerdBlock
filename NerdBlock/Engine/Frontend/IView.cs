namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents a view that displays data
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Handles loading the ouptut fields into the view if applicable
        /// </summary>
        void LoadView(IoMap map);
    }
}
