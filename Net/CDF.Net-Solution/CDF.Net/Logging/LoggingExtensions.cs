using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace CDF.Net.Logging
{
    /// <summary>
    /// Extension class that captures member and source code location data as part of the logging process. This also adds extended logging commands to support capturing the entering and exiting of members.
    /// </summary>
    public static class LoggingExtensions
    {
        /// <summary>
        /// The name of the property to be passed into the logging framework for the calling member that called into logging.
        /// </summary>
        public const string PropertyMemberName = "MemberName";

        /// <summary>
        /// The name of the property that captures the line number where the logging event occured.
        /// </summary>
        public const string PropertyLineNumber = "LineNumber";

        /// <summary>
        /// The default value to used when logging the default event id's.
        /// </summary>
        private static readonly EventId DefaultEventId = default;


        /// <summary>
        /// Logging a trace level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceEnterLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a trace level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceEnterLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a trace level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceExitLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a trace level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceExitLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a trace level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceLog(this ILogger source, string message, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, DefaultEventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a trace level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceLog(this ILogger source, string message,EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, eventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a trace level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceLog(this ILogger source, string message, Exception exception, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, DefaultEventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a trace level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void TraceLog(this ILogger source, string message, Exception exception, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Trace)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Trace, eventId, logEvent, exception, LogEventProperties.Formatter);
            
        }



        /// <summary>
        /// Logging a Debug level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugEnterLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Debug level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugEnterLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Debug level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugExitLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Debug level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugExitLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, eventId, logEvent, null, LogEventProperties.Formatter);
        

        }

        /// <summary>
        /// Logging a Debug level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugLog(this ILogger source, string message, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, DefaultEventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Debug level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugLog(this ILogger source, string message,EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, eventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Debug level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugLog(this ILogger source, string message, Exception exception, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, DefaultEventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Debug level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void DebugLog(this ILogger source, string message, Exception exception, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Debug)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Debug, eventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Information level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationEnterLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Information level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationEnterLog(this ILogger source,EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Information level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationExitLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Information level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationExitLog(this ILogger source, EventId eventId,[CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Information level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationLog(this ILogger source, string message, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, DefaultEventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Information level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationLog(this ILogger source, string message, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, eventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Information level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationLog(this ILogger source, string message, Exception exception, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, DefaultEventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Information level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void InformationLog(this ILogger source, string message, Exception exception, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Information)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Information, eventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Warning level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningEnterLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Warning level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningEnterLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Warning level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningExitLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Warning level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningExitLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Warning level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningLog(this ILogger source, string message, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, DefaultEventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Warning level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningLog(this ILogger source, string message, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, eventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Warning level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningLog(this ILogger source, string message, Exception exception, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, DefaultEventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Warning level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void WarningLog(this ILogger source, string message, Exception exception, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Warning)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Warning, eventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Error level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorEnterLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Error level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorEnterLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Error level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorExitLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Error level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorExitLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Error level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorLog(this ILogger source, string message, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, DefaultEventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Error level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorLog(this ILogger source, string message, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, eventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Error level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorLog(this ILogger source, string message, Exception exception, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, DefaultEventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Error level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void ErrorLog(this ILogger source, string message, Exception exception, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Error)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Error, eventId, logEvent, exception, LogEventProperties.Formatter);
        }


        /// <summary>
        /// Logging a Critical level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalEnterLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Critical level message noting the enter into a member..
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalEnterLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;


            var logEvent = new LogEventProperties($"Entering '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, eventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Critical level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalExitLog(this ILogger source, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, DefaultEventId, logEvent, null, LogEventProperties.Formatter);

        }

        /// <summary>
        /// Logging a Critical level message noting the exiting a member.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalExitLog(this ILogger source, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;


            var logEvent = new LogEventProperties($"Exiting '{memberName}'");
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, eventId, logEvent, null, LogEventProperties.Formatter);

        }


        /// <summary>
        /// Logging a Critical level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalLog(this ILogger source, string message, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, DefaultEventId, logEvent, null, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Critical level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalLog(this ILogger source, string message, EventId eventId, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, eventId, logEvent, null, LogEventProperties.Formatter);
        }


        /// <summary>
        /// Logging a Critical level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalLog(this ILogger source, string message, Exception exception, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, DefaultEventId, logEvent, exception, LogEventProperties.Formatter);
        }

        /// <summary>
        /// Logging a Critical level message to the logger.
        /// </summary>
        /// <param name="source">The logger to log the message to.</param>
        /// <param name="message">The message to be added to the logger.</param>
        /// <param name="exception">Exception to be logged.</param>
        /// <param name="eventId">The event id to be assigned to the log message.</param>
        /// <param name="memberName">Auto filled in by the system.</param>
        /// <param name="lineNumber">Auto filled in by the system.</param>
        public static void CriticalLog(this ILogger source, string message, EventId eventId, Exception exception, [CallerMemberName] string memberName = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (source == null) return;

            if (!source.IsEnabled(LogLevel.Critical)) return;

            if (string.IsNullOrEmpty(message)) return;

            var logEvent = new LogEventProperties(message);
            logEvent.AddProp(PropertyMemberName, memberName);
            logEvent.AddProp(PropertyLineNumber, lineNumber);
            source.Log(LogLevel.Critical, eventId, logEvent, exception, LogEventProperties.Formatter);
        }

    }
}
