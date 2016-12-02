namespace NerdBlock.Engine.Frontend
{
    /// <summary>
    /// Represents the severity of a flash message
    /// </summary>
    public enum FlashMessageType
    {
        /// <summary>
        /// The message is a neutral informative message
        /// </summary>
        Neutral = 0,
        /// <summary>
        /// The message is a positive informative message
        /// </summary>
        Good = 1,
        /// <summary>
        /// The message is a negative informative message
        /// </summary>
        Bad = 2,
        /// <summary>
        /// The message is a fatal exception message
        /// </summary>
        Fatal = 4
    }
}
