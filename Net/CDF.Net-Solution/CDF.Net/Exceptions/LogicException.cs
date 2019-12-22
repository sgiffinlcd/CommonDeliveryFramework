using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that an exception has occured within the applications executing logic and a application safe message has been provided with the exception.
    /// </summary>
    public class LogicException: ManagedException
    {
        /// <summary>
        /// Creates an instance of <see cref="LogicException"/> and returns the default exception message.
        /// </summary>
        public LogicException() : base(StandardExceptionMessages.LogicException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="LogicException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public LogicException(Exception internalException) : base(StandardExceptionMessages.LogicException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="LogicException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public LogicException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="LogicException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public LogicException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
