using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that a communications exception has occured and application safe message has been provided with the exception.
    /// </summary>
    public class CommunicationsException:ManagedException
    {
        /// <summary>
        /// Creates an instance of <see cref="CommunicationsException"/> and returns the default exception message.
        /// </summary>
        public CommunicationsException() : base(StandardExceptionMessages.CommunicationsException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="CommunicationsException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public CommunicationsException(Exception internalException) : base(StandardExceptionMessages.CommunicationsException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="CommunicationsException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public CommunicationsException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="CommunicationsException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public CommunicationsException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
