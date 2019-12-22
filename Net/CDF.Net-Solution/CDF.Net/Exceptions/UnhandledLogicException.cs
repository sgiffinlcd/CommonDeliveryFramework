using System;


namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that an exception has occured within the applications executing logic that was handled by error handling in the logic and a application safe message has been provided with the exception.
    /// </summary>
    public class UnhandledLogicException : LogicException
    {
        /// <summary>
        /// Creates an instance of <see cref="UnhandledLogicException"/> and returns the default exception message.
        /// </summary>
        public UnhandledLogicException() : base(StandardExceptionMessages.UnhandledLogicException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="UnhandledLogicException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public UnhandledLogicException(Exception internalException) : base(StandardExceptionMessages.UnhandledLogicException,
            internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="UnhandledLogicException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public UnhandledLogicException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="UnhandledLogicException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public UnhandledLogicException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }

}