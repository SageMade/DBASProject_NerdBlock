namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents an output field for a view
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// Gets the name that this output uses. This will be put into the context before performing an action
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Sets the value for the output
        /// </summary>
        object Value { set; }

        void Fill(IoMap map);
    }
}
