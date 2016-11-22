using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock
{
    /// <summary>
    /// A utility for logging information to a human-readable text file
    /// </summary>
    public class Logger : TextWriter
    {
        #region Class-Level

        /// <summary>
        /// Gets the time format for the log's time stamps
        /// </summary>
        public static readonly string LOG_TIME_FORMAT = "HH:mm:ss";
        /// <summary>
        /// Gets the date format for log file naming
        /// </summary>
        public static readonly string LOG_FILE_TIME_FORMAT = "yyyy-MM-dd_HH_mm";

        /// <summary>
        /// Stores a singleton isntance of a logger for use statically
        /// </summary>
        private static Logger mySingleton;

        /// <summary>
        /// Gets the singleton instance of the logger, created when any logger function was invoked or referenced
        /// </summary>
        public static Logger Singleton
        {
            get { return mySingleton; }
        }

        /// <summary>
        /// Static contructor, creates a new isntance of the logger
        /// </summary>
        static Logger()
        {
            mySingleton = new Logger();
        }

        #endregion

        #region Instance-Level

        /// <summary>
        /// The stream to write to
        /// </summary>
        private StreamWriter myStream;
        /// <summary>
        /// The stream to write the error log to
        /// </summary>
        private StreamWriter myErrorStream;

        /// <summary>
        /// Creates a new isntance of a logger
        /// </summary>
        public Logger()
        {
            int index = 0;

            // We will try to get a stream as long as we don't have one, and limit to 100 attempts
            while (myStream == null && index < 100)
            {
                // See if we can open the stream
                try
                {
                    // Get a nice logfile name, with index if required
                    string fileName = "log_info" + (index > 0 ? "(" + index + ")" : "") + ".txt";
                    // Open the file
                    myStream = new StreamWriter(fileName);
                }
                // If we can't access the file, move to the next one
                catch (IOException) { index++; }
            }
        }

        /// <summary>
        /// Handles writing a line of text to the info log stream
        /// </summary>
        /// <param name="line">The line to write</param>
        new private void WriteLine(string line)
        {
            myStream.WriteLine(line);
            myStream.Flush();
        }

        /// <summary>
        /// Handles writing a line of text to the error log stream. This will also write to
        /// the info log. If the error log has not been created it will be created here
        /// </summary>
        /// <param name="line">The line to write</param>
        private void WriteError(string line)
        {
            // If we do not have an error stream
            if (myErrorStream == null)
            {
                int index = 0;

                // As long as we don't have a stream, try to make one
                while (myErrorStream == null && index < 100)
                {
                    try
                    {
                        // Get a nice logfile name, with time and an index if required
                        string fileName = "log_errors" + DateTime.Now.ToString(LOG_FILE_TIME_FORMAT) + (index > 0 ? "(" + index + ")" : "") + ".txt";
                        // Open the log file
                        myErrorStream = new StreamWriter(fileName);
                    }
                    catch (IOException) { index++; }
                }
            }

            myStream.WriteLine(line);
            myStream.Flush();

            myErrorStream.WriteLine(line);
            myErrorStream.Flush();
        }

        /// <summary>
        /// Handles writing an error line from a format string. This will call the underlying
        /// WriteError(string) method
        /// </summary>
        /// <param name="format">The string to place the formatted data into (see string.format)</param>
        /// <param name="parameters">The parameters to format into the string</param>
        private void WriteError(string format, params object[] parameters)
        {
            WriteError(string.Format(format, parameters));
        }

        /// <summary>
        /// Writes an exception to the log
        /// </summary>
        /// <param name="e">The exception to log</param>
        public static void Log(Exception e)
        {
            Log(LogLevel.Exception, "Encountered {0} at:", e.GetType().Name);

            StackTrace trace = new StackTrace(e, true);

            foreach (StackFrame frame in trace.GetFrames())
            {
                mySingleton.WriteError("\t\t{0}.{1} - line {2}", frame.GetMethod().DeclaringType, frame.GetMethod().Name, frame.GetFileLineNumber());
            }
        }

        public static void AssertEquals(object left, object right, string validMessage = null, string invalidMessage = null)
        {
            validMessage = validMessage == null ? string.Format("{0}=={1}", left, right) : validMessage;
            invalidMessage = invalidMessage == null ? string.Format("{0}!={1}", left, right) : invalidMessage;

            if (left == null && right == null)
                Log(LogLevel.Info, validMessage);
            else if (right == null || left == null)
                Log(LogLevel.Warn, invalidMessage);
            else if (left.Equals(right))
                Log(LogLevel.Info, validMessage);
            else
                Log(LogLevel.Warn, invalidMessage);
        }

        /// <summary>
        /// Writes single line of unformatted text to the log file
        /// </summary>
        /// <param name="level">The severity level for the message, used to determine if the message should be written to the error log as well</param>
        /// <param name="rawText">The line to write</param>
        public static void LogRaw(LogLevel level, string rawText)
        {
            if (level < LogLevel.Error)
                mySingleton.WriteLine(rawText);
            else
                mySingleton.WriteError(rawText);
        }

        /// <summary>
        /// Writes a single line of formatted text to the log file
        /// </summary>
        /// <param name="level">The severity level for the message, used to determine if the message should be written to the error log as well</param>
        /// <param name="format">The format string</param>
        /// <param name="parameters">The parameters for the format</param>
        public static void Log(LogLevel level, string format, params object[] parameters)
        {
            while (format.StartsWith("\n"))
            {
                LogRaw(level, "");
                format = format.Remove(0, 1);
            }

            if (level >= LogLevel.Error)
                mySingleton.WriteError(string.Format("[{0}] - [{1}] {2}", DateTime.Now.ToString(LOG_TIME_FORMAT), level, string.Format(format, parameters)));
            else
                mySingleton.WriteLine(string.Format("[{0}] - [{1}] {2}", DateTime.Now.ToString(LOG_TIME_FORMAT), level, string.Format(format, parameters)));
        }

        /// <summary>
        /// Gets the encoding for this logger, will be ASCII
        /// </summary>
        public override Encoding Encoding
        {
            get { return Encoding.ASCII; }
        }

        #endregion

    }

    /// <summary>
    /// Represents the level of severity for a log message
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// The log line is purely informational, no need for concern
        /// </summary>
        Info = 1,
        /// <summary>
        /// The log line is a warning, program flow will proceed as normal
        /// </summary>
        Warn = 2,
        /// <summary>
        /// The log line is an error, program flow will likely be altered
        /// </summary>
        Error = 4,
        /// <summary>
        /// The log line is an exception, the program will likely crash, but may attempt to recover itself
        /// </summary>
        Exception = 8,
        /// <summary>
        /// The log line is fatal, the program will immediately crash
        /// </summary>
        Fatal = 16
    }
}
