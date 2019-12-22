using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Base implementation of exceptions that have been managed by the application implementation. All managed exceptions will inherit from this exception type.
    /// </summary>
    public class ManagedException : Exception
    {
        /// <summary>
        /// Creates an instance of <see cref="ManagedException"/> and returns the default exception message.
        /// </summary>
        public ManagedException() : base(StandardExceptionMessages.ManagedException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="ManagedException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public ManagedException(Exception internalException) : base(StandardExceptionMessages.ManagedException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="ManagedException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public ManagedException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="ManagedException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public ManagedException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
