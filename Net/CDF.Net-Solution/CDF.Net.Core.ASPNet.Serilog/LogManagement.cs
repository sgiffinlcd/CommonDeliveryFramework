using Microsoft.AspNetCore.Hosting;
using Serilog.Extensions.Logging;
using Serilog;

namespace CDF.Net.Core.ASPNet.Serilog
{
    /// <summary>
    /// Management Class that is responsible for the registration and managment of logging for ASP.Net core hosted applications.
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
        public static IWebHostBuilder UseCDFLogging(this IWebHostBuilder builder)
        {
            return builder.UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
                .ReadFrom.Configuration(hostingContext.Configuration)
                .Enrich.FromLogContext()
                .WriteTo.Providers(SerilogProviders));
        }
    }
}
