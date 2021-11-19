/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Piranha.Manager.Models;
using Piranha.Manager.Models.ConfigModels;
using Piranha.Manager.Services;

namespace Piranha.Manager.Controllers;

/// <summary>
/// Api controller for config management.
/// </summary>
[Area("Manager")]
[Route("manager/api/config")]
[Authorize(Policy = Permission.Admin)]
[ApiController]
[AutoValidateAntiforgeryToken]
public class ConfigApiController : Controller
{
    private readonly ConfigService _service;
    private readonly ILogger _logger;

    /// <summary>
    /// Default constructor.
    /// </summary>
    public ConfigApiController(ConfigService service, ILoggerFactory factory = null)
    {
        _service = service;
        _logger = factory?.CreateLogger<ConfigApiController>();
    }

    /// <summary>
    /// Gets the list model.
    /// </summary>
    /// <returns>The list model</returns>
    [Route("")]
    [HttpGet]
    [Authorize(Policy = Permission.Config)]
    public ConfigEditModel List()
    {
        return _service.Get();
    }

    /// <summary>
    /// Save the given model.
    /// </summary>
    /// <param name="model">The config model</param>
    [Route("save")]
    [HttpPost]
    [Authorize(Policy = Permission.ConfigEdit)]
    [SuppressMessage("Microsoft.Design", "CA1031", Justification = "Logging should catch all exceptions")]
    public AsyncResult Save(ConfigEditModel model)
    {
        try
        {
            _service.Save(model);
        }
        catch (Exception e)
        {
            _logger?.LogError("Save() {Message}", e.Message);

            return new AsyncResult
            {
                Status = new StatusMessage
                {
                    Type = StatusMessage.Error,
                    Body = "An error occurred while saving"
                }
            };
        }
        return new AsyncResult
        {
            Status = new StatusMessage
            {
                Type = StatusMessage.Success,
                Body = "The config was successfully saved"
            }
        };
    }
}
