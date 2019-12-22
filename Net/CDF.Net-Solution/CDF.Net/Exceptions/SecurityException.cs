using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that a security exception has been captured and a application safe message has been added to this exception.
    /// </summary>
    public class SecurityException:ManagedException
    {
        /// <summary>
        /// Creates an instance of <see cref="SecurityException"/> and returns the default exception message.
        /// </summary>
        public SecurityException() : base(StandardExceptionMessages.SecurityException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="SecurityException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public SecurityException(Exception internalException) : base(StandardExceptionMessages.SecurityException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="SecurityException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public SecurityException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="SecurityException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public SecurityException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
