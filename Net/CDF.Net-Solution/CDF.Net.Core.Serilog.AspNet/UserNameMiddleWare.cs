using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Serilog.Context;

namespace CDF.Net.Core.Serilog.AspNet
{
    /// <summary>
    /// Middle ware that will register the user name provided by the <see cref="HttpContext"/> identity.
    /// </summary>
    public class UserNameMiddleWare:HttpContextAccessor
    {
        /// <summary>
        /// Delegate to be requested next.
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Constructor to register the middleware.
        /// </summary>
        /// <param name="next">Next delegate to execute.</param>
        public UserNameMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var userName = context.User.Identity.IsAuthenticated ? context.User.Identity.Name : null;
            if(string.IsNullOrEmpty(userName)) userName = "unknown";

            LogContext.PushProperty("UserName", userName);
            await _next.Invoke(context);
        }

    }
}
