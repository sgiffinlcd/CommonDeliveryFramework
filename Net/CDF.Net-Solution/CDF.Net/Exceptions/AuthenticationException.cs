using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that a security authentication exception has occured and application safe message has been provided with the exception.
    /// </summary>
    public class AuthenticationException:SecurityException
    {
        /// <summary>
        /// Creates an instance of <see cref="AuthenticationException"/> and returns the default exception message.
        /// </summary>
        public AuthenticationException() : base(StandardExceptionMessages.AuthenticationException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="AuthenticationException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public AuthenticationException(Exception internalException) : base(StandardExceptionMessages.AuthenticationException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="AuthenticationException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public AuthenticationException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="AuthenticationException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public AuthenticationException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
