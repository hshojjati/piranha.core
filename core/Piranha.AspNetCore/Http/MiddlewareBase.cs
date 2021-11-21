/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Piranha.AspNetCore.Services;

namespace Piranha.AspNetCore.Http;

/// <summary>
/// Base class for middleware.
/// </summary>
public abstract class MiddlewareBase
{
    /// <summary>
    /// The next middleware in the pipeline.
    /// </summary>
    protected RequestDelegate Next { get; }

    /// <summary>
    /// The optional logger.
    /// </summary>
    protected ILogger Logger { get; }

    /// <summary>
    /// Creates a new middleware instance.
    /// </summary>
    /// <param name="next">The next middleware in the pipeline</param>
    protected MiddlewareBase(RequestDelegate next)
    {
        Next = next;
    }

    /// <summary>
    /// Creates a new middleware instance.
    /// </summary>
    /// <param name="next">The next middleware in the pipeline</param>
    /// <param name="factory">The logger factory</param>
    protected MiddlewareBase(RequestDelegate next, ILoggerFactory factory) : this(next)
    {
        if (factory != null)
        {
            Logger = factory.CreateLogger(this.GetType().FullName);
        }
    }

    /// <summary>
    /// Invokes the middleware.
    /// </summary>
    /// <param name="context">The current http context</param>
    /// <param name="api">The current api</param>
    /// <param name="service">The application service</param>
    /// <returns>An async task</returns>
    public abstract Task Invoke(HttpContext context, IApi api, IApplicationService service);

    /// <summary>
    /// Checks if the request has already been handled by another
    /// Piranha middleware.
    /// </summary>
    /// <param name="context">The current http context</param>
    /// <returns>If the request has already been handled</returns>
    protected static bool IsHandled(HttpContext context)
    {
        var values = context.Request.Query["piranha_handled"];
        if (values.Count > 0)
        {
            return values[0] == "true";
        }
        return false;
    }

    /// <summary>
    /// Checks if the request wants a draft.
    /// </summary>
    /// <param name="context">The current http context</param>
    /// <returns>If the request is for a draft</returns>
    protected static bool IsDraft(HttpContext context)
    {
        var values = context.Request.Query["draft"];
        if (values.Count > 0)
        {
            return values[0] == "true";
        }
        return false;
    }

    /// <summary>
    /// Checks if this is a manager request.
    /// </summary>
    /// <param name="route">The url</param>
    /// <returns>If the given route is for the manager application</returns>
    protected static bool IsManagerRequest(string route)
    {
        if (string.IsNullOrEmpty(route))
        {
            return false;
        }

        if (route.StartsWith("/manager/") || route == "/manager")
        {
            return true;
        }
        return false;
    }
}
