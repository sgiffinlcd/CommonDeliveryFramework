using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog.Extensions.Logging;
using Serilog;

namespace CDF.Net.Core.Serilog.AspNet
{
    /// <summary>
    /// Management Class that is responsible for the registration and management of logging for ASP.Net core hosted applications.
    /// </summary>
    public static class LogManagement
    {
        /// <summary>
        /// Logging providers collection that will be used to support the <see cref="Microsoft.Extensions.Logging.ILogger"/> interface.
        /// </summary>
        private static readonly LoggerProviderCollection SerilogProviders = new LoggerProviderCollection();

        /// <summary>
        /// Extension method that loads the utility logging model into the aspnet core application. 
        /// </summary>
        /// <param name="builder">The web host builder that the logging will be hosted in.</param>
        /// <returns>Reference to the web host builder that utilities logging has been added.</returns>
        public static IWebHostBuilder UseCDFLogging(this IWebHostBuilder builder,bool logMachineName = true,bool logThreadId = false, bool logThreadName = false)
        {
            return builder.UseSerilog((hostingContext, loggerConfiguration) =>
            {
                
                loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
                if (logMachineName) loggerConfiguration.Enrich.WithMachineName();
                if (logThreadId) loggerConfiguration.Enrich.WithThreadId();
                if (logThreadName) loggerConfiguration.Enrich.WithThreadName();
                loggerConfiguration.Enrich.FromLogContext().WriteTo.Providers(SerilogProviders);

            });

        }

        /// <summary>
        /// Extension method that loads the utility logging model into the aspnet core application. 
        /// </summary>
        /// <param name="builder">The web host builder that the logging will be hosted in.</param>
        /// <param name="configureLogger">Delegate definition for loading a custom serilog configuration.</param>
        /// <returns>Reference to the web host builder that utilities logging has been added.</returns>
        public static IWebHostBuilder UseCDFLogging(this IWebHostBuilder builder, Func<LoggerConfiguration,IConfiguration,LoggerConfiguration> configureLogger)
        {
            return builder.UseSerilog((hostingContext, loggerConfiguration) =>
            {
                loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
                configureLogger(loggerConfiguration,hostingContext.Configuration);
                loggerConfiguration.Enrich.FromLogContext().WriteTo.Providers(SerilogProviders);
            });

        }

        /// <summary>
        /// Registers the user name property to be added to logging
        /// </summary>
        /// <param name="builder">Application builder to register the middleware with.</param>
        /// <returns>The application builder</returns>
        public static IApplicationBuilder UseUserNameLoggerProperty(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserNameMiddleWare>();
        }
    }
}
