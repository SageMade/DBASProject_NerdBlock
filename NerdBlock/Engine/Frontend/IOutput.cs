namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents an output field for a view
    /// </summary>
    public interface IOutput : INamed
    {
        /// <summary>
        /// Sets the value for the output
        /// </summary>
        object Value { set; }

        void Fill(IoMap map);
    }
}
