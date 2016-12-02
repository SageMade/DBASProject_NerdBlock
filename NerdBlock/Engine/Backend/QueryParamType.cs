namespace NerdBlock.Engine.Backend
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
        /// <summary>
        /// Represents rectangular box
        /// </summary>
        Box,
        /// <summary>
        /// Represents an array of bytes
        /// </summary>
        ByteArray,
        /// <summary>
        /// Represents a single character
        /// </summary>
        Char,
        /// <summary>
        /// Represents a variable length character
        /// </summary>
        VarChar,
        /// <summary>
        /// Represents an Ip address
        /// </summary>
        IpAddress,
        /// <summary>
        /// Represents a 2D geometric circle
        /// </summary>
        Circle,
        /// <summary>
        /// Represents a date
        /// </summary>
        Date,
        /// <summary>
        /// Represents a double-precision floating point value
        /// </summary>
        Double,
        /// <summary>
        /// Represents a 32-bit signed integer
        /// </summary>
        Integer,
        /// <summary>
        /// Represents a time of span
        /// </summary>
        TimeSpan,
        /// <summary>
        /// Represents a json-encoded text object
        /// </summary>
        Json,
        /// <summary>
        /// Represents an infinitely long 2D geometric line
        /// </summary>
        Line,
        /// <summary>
        /// Represents a 2d line segment
        /// </summary>
        LineSegment,
        /// <summary>
        /// Represents a mac address
        /// </summary>
        MacAddress,
        /// <summary>
        /// Represents a numeric type that is optimized for storing currencies
        /// </summary>
        Money,
        /// <summary>
        /// Reprents a numeric type
        /// </summary>
        Numeric,
        /// <summary>
        /// Represents a 2d geometric path
        /// </summary>
        Path,
        /// <summary>
        /// Represents a point in 2d space
        /// </summary>
        Point,
        /// <summary>
        /// Represents a polygon in 2d space
        /// </summary>
        Polygon,
        /// <summary>
        /// Represents a single-precision floating point value
        /// </summary>
        Single,
        /// <summary>
        /// Represents a 16-bit signed integer
        /// </summary>
        Short,
        /// <summary>
        /// Represents a long text field
        /// </summary>
        Text,
        /// <summary>
        /// Represents a single point in time
        /// </summary>
        Time,
        /// <summary>
        /// Represents a time stamp based on Unix time
        /// </summary>
        TimeStamp,
        /// <summary>
        /// Represents a universally unique identifier
        /// </summary>
        Uuid,
        /// <summary>
        /// Represents an xml encoded string object
        /// </summary>
        Xml
    }
}