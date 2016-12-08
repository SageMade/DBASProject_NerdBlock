namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents an input element on a view
    /// </summary>
    public interface IInput : INamed
    {
        /// <summary>
        /// Gets or sets the value from the input
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// Fills the input with the given values in the IO map
        /// </summary>
        /// <param name="map">The IO map to use for filling</param>
        void Fill(IoMap map);

        /// <summary>
        /// Ppoulates the IO map from this input. This will be called before an action
        /// </summary>
        /// <param name="currentMap">The map to populate</param>
        void PopulateMap(IoMap currentMap);
    }
}
