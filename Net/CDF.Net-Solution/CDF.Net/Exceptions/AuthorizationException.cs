using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that a security authorization exception has occured and application safe message has been provided with the exception.
    /// </summary>
    public class AuthorizationException:SecurityException
    {
        /// <summary>
        /// Creates an instance of <see cref="AuthorizationException"/> and returns the default exception message.
        /// </summary>
        public AuthorizationException() : base(StandardExceptionMessages.AuthorizationException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="AuthorizationException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public AuthorizationException(Exception internalException) : base(StandardExceptionMessages.AuthorizationException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="AuthorizationException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public AuthorizationException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="AuthorizationException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public AuthorizationException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
