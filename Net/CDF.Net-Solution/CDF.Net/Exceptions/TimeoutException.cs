using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that communications with an external resource has timed out and an application safe message has been provided with the exception.
    /// </summary>
    public class TimeoutException:CommunicationsException
    {
        /// <summary>
        /// Creates an instance of <see cref="TimeoutException"/> and returns the default exception message.
        /// </summary>
        public TimeoutException() : base(StandardExceptionMessages.TimeoutException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="TimeoutException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public TimeoutException(Exception internalException) : base(StandardExceptionMessages.TimeoutException,
            internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="TimeoutException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public TimeoutException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="TimeoutException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public TimeoutException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
