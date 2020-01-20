using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace CDF.Net.Logging
{
    /// <summary>
    /// Static log management class. To be used when a stand alone static log manager is needed for a solution.
    /// </summary>
    public static class LogManager
    {
        /// <summary>
        /// the logging factory to be used by the application.
        /// </summary>
        private static ILoggerFactory _loggerFactory;

        /// <summary>
        /// flag that determines if the logger has been loaded.
        /// </summary>
        private static bool _factoryLoaded = false;

        public static void InitalizeManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
            _factoryLoaded = true;
        }

        /// <summary>
        /// Creates an instance of a logger from the logger factory.
        /// </summary>
        /// <typeparam name="T">The type of the class that is consuming the logger.</typeparam>
        /// <returns>Instance of the logger. If the logger has not been initialized then an empty logger will be returned.</returns>
        public static ILogger<T> CreateLogger<T>() where T : class
        {
            return _factoryLoaded ? _loggerFactory.CreateLogger<T>() : NullLogger<T>.Instance;
        }
    }
}
