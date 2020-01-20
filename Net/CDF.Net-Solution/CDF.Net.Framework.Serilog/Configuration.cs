using System;
using CDF.Net.Logging;
using Serilog;


namespace CDF.Net.Framework.Serilog
{

    /// <summary>
    /// Configuration manager that loads the log manager configuration when using the static stand alone <see cref="LogManager"/>.
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Setup and configuration of the <see cref="LogManager"/> with the entire configuration being loaded from the config file.
        /// <param name="includeMachineName">Optional parameter that determines if the machine name will be included in the logging, this is set to a default value of true.</param>
        /// <param name="includeThreadId">Optional parameter that determines if the executing thread id will be included in the logging, this is set to a default value of false.</param>
        /// <param name="includeThreadName">Optional parameter that determines if the executing thread name will be included in the logging, this is set to a default value of false. </param>
        /// </summary>
        public static void LoadLogManager(bool includeMachineName = true, bool includeThreadId = true, bool includeThreadName = false)
        {
            // instantiate and configure logging. Using serilog here, to log to console and a text-file.
            var loggerFactory = new Microsoft.Extensions.Logging.LoggerFactory();
            var loggerConfig = LoadConfiguration();

            if (includeMachineName) loggerConfig.Enrich.WithMachineName();
            if (includeThreadId) loggerConfig.Enrich.WithThreadId();
            if (includeThreadName) loggerConfig.Enrich.WithThreadName();

            var logger = loggerConfig.CreateLogger();
            var loadedFactory = loggerFactory.AddSerilog(logger);

            LogManager.InitalizeManager(loadedFactory);
        }

        /// <summary>
        /// Setup and configuration of the <see cref="LogManager"/> with a custom serilog built configuration.
        /// </summary>
        /// <param name="configuration">The Serilog configure to be loaded.</param>
        /// <exception cref="ArgumentNullException">Thrown when a null configuration is provided.</exception>
        public static void LoadLogManager(LoggerConfiguration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            var logger = configuration.CreateLogger();
            var loggerFactory = new Microsoft.Extensions.Logging.LoggerFactory();
            var loadedFactory = loggerFactory.AddSerilog(logger);

            LogManager.InitalizeManager(loadedFactory);
        }

        /// <summary>
        /// Loads the logger configuration from the application settings.
        /// </summary>
        /// <returns>The fully loaded logger configuration.</returns>
        public static LoggerConfiguration LoadConfiguration()
        {
            var loggerConfig = new LoggerConfiguration();
            return loggerConfig.ReadFrom.AppSettings();
        }
    }
}
