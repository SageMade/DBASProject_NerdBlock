namespace NerdBlock.Sandbox
{
    /// <summary>
    /// Represents the data type that a query parameter excepts
    /// </summary>
    public enum QueryParamType
    {
        /// <summary>
        /// Represents a signed, 8-bit character
        /// </summary>
        Long,
        /// <summary>
        /// Represents a bit field of a fixed length
        /// </summary>
        Bit,
        /// <summary>
        /// Represents a bit field of a varying length
        /// </summary>
        VarBit,
        /// <summary>
        /// Represents a true or false value
        /// </summary>
        Boolean,
        Box,
        ByteArray,
        Char,
        VarChar,
        IpAddress,
        Circle,
        Date,
        Double,
        Integer,
        TimeSpan,
        Json,
        Line,
        LineSegment,
        MacAddress,
        Money,
        Numeric,
        Path,
        Point,
        Polygon,
        Single,
        Short,
        Text,
        Time,
        TimeStamp,
        Uuid,
        Xml
    }
}