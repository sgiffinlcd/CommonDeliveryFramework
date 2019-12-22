using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that access is denied when communicating to an external resource and application safe message has been provided with the exception.
    /// </summary>
    public class ExternalAccessDeniedException : CommunicationsException
    {
        /// <summary>
        /// Creates an instance of <see cref="ExternalAccessDeniedException"/> and returns the default exception message.
        /// </summary>
        public ExternalAccessDeniedException() : base(StandardExceptionMessages.ExternalAccessDeniedException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="ExternalAccessDeniedException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public ExternalAccessDeniedException(Exception internalException) : base(StandardExceptionMessages.ExternalAccessDeniedException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="ExternalAccessDeniedException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public ExternalAccessDeniedException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="ExternalAccessDeniedException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public ExternalAccessDeniedException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
