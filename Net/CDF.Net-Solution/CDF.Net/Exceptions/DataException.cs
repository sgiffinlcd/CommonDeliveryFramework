using System;
using System.Collections.Generic;
using System.Text;

namespace CDF.Net.Exceptions
{
    /// <summary>
    /// Notifies that an exception has occured while managing data within the application an application safe message has been provided with the exception.
    /// </summary>
    public class DataException:ManagedException
    {
        /// <summary>
        /// Creates an instance of <see cref="DataException"/> and returns the default exception message.
        /// </summary>
        public DataException() : base(StandardExceptionMessages.DataException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="DataException"/> that returns the default exception message and an imbedded exception.
        /// </summary>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public DataException(Exception internalException) : base(StandardExceptionMessages.DataException, internalException)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="DataException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        public DataException(string message) : base(message)
        {
            //Intentionally blank
        }

        /// <summary>
        /// Creates an instance of <see cref="DataException"/> exception class.
        /// </summary>
        /// <param name="message">Message to be returned as part of the exception.</param>
        /// <param name="internalException">Existing exception to be added to this exception.</param>
        public DataException(string message, Exception internalException) : base(message, internalException)
        {
            //Intentionally blank
        }
    }
}
