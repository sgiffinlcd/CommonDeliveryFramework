using System;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that an exception has occured while validating data within the application an application safe message has been provided with the exception.
    /// </summary>
    public class DataValidationException:DataException
    {


        /// <summary>
        /// Creates an instance of <see cref="DataValidationException"/> and returns the default exception message.
        /// </summary>
        public DataValidationException() : base(StandardExceptionMessages.DataValidationException)
        {
            //Intentionally Blank
        }

        /// <summary>
        /// Creates an instance of <see cref="DataValidationException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public DataValidationException(Exception internalException, string dataField = null) : base(StandardExceptionMessages.DataValidationException, internalException)
        {
            //Intentionally Blank
        }

        /// <summary>
        /// Creates an instance of <see cref="DataValidationException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>

        public DataValidationException(string message) : base(message)
        {
            //Intentionally Blank
        }

        /// <summary>
        /// Creates an instance of <see cref="DataValidationException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public DataValidationException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally Blank
        }
    }
}
