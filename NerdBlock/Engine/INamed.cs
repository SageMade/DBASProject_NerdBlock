namespace NerdBlock.Engine
{
    /// <summary>
    /// Interface for an item that has a string name
    /// </summary>
    public interface INamed
    {
        /// <summary>
        /// Get the name of the item
        /// </summary>
        string Name { get; }
    }
}