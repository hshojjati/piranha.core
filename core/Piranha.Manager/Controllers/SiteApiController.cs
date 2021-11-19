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
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Piranha.Manager.Models;
using Piranha.Manager.Models.SiteModels;
using Piranha.Manager.Services;

namespace Piranha.Manager.Controllers;

/// <summary>
/// Api controller for site management.
/// </summary>
[Area("Manager")]
[Route("manager/api/site")]
[Authorize(Policy = Permission.Admin)]
[ApiController]
[AutoValidateAntiforgeryToken]
public class SiteApiController : Controller
{
    private readonly SiteService _service;
    private readonly ManagerLocalizer _localizer;
    private readonly ILogger _logger;

    /// <summary>
    /// Default constructor.
    /// </summary>
    public SiteApiController(SiteService service, ManagerLocalizer localizer, ILoggerFactory factory = null)
    {
        _service = service;
        _localizer = localizer;
        _logger = factory?.CreateLogger<SiteApiController>();
    }

    /// <summary>
    /// Gets the site with the given id.
    /// </summary>
    /// <param name="id">The unique id</param>
    /// <returns>The page edit model</returns>
    [Route("{id:Guid}")]
    [HttpGet]
    [Authorize(Policy = Permission.SitesEdit)]
    public async Task<SiteEditModel> Get(Guid id)
    {
        return await _service.GetById(id);
    }

    /// <summary>
    /// Gets the site content with the given id.
    /// </summary>
    /// <param name="id">The unique id</param>
    /// <returns>The page edit model</returns>
    [Route("content/{id:Guid}")]
    [HttpGet]
    [Authorize(Policy = Permission.SitesEdit)]
    public async Task<IActionResult> GetContent(Guid id)
    {
        var model = await _service.GetContentById(id);

        if (model != null)
        {
            return Ok(model);
        }
        return NotFound();
    }

    /// <summary>
    /// Creates a new site.
    /// </summary>
    /// <returns>The site edit model</returns>
    [Route("create")]
    [HttpGet]
    [Authorize(Policy = Permission.SitesAdd)]
    public async Task<SiteEditModel> Create()
    {
        return await _service.Create();
    }

    /// <summary>
    /// Gets the site with the given id.
    /// </summary>
    /// <param name="model">The site model</param>
    /// <returns>The status of the operation</returns>
    [Route("save")]
    [HttpPost]
    [Authorize(Policy = Permission.SitesEdit)]
    [SuppressMessage("Microsoft.Design", "CA1031", Justification = "Logging should catch all exceptions")]
    public async Task<StatusMessage> Save(SiteEditModel model)
    {
        try
        {
            await _service.Save(model);
        }
        catch (ValidationException e)
        {
            // Validation did not succeed
            return new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = e.Message
            };
        }
        catch (Exception e)
        {
            _logger?.LogError("Save() {Message}", e.Message);

            return new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = _localizer.Site["An error occured while saving the site"]
            };
        }

        return new StatusMessage
        {
            Type = StatusMessage.Success,
            Body = _localizer.Site["The site was successfully saved"]
        };
    }

    /// <summary>
    /// Gets the site with the given id.
    /// </summary>
    /// <param name="model">The site model</param>
    /// <returns>The status of the operation</returns>
    [Route("savecontent")]
    [HttpPost]
    [Authorize(Policy = Permission.SitesEdit)]
    [SuppressMessage("Microsoft.Design", "CA1031", Justification = "Logging should catch all exceptions")]
    public async Task<StatusMessage> SaveContent(SiteContentEditModel model)
    {
        try
        {
            await _service.SaveContent(model);
        }
        catch (ValidationException e)
        {
            // Validation did not succeed
            return new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = e.Message
            };
        }
        catch (Exception e)
        {
            _logger?.LogError("Save() {Message}", e.Message);

            return new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = _localizer.Site["An error occured while saving the site"]
            };
        }

        return new StatusMessage
        {
            Type = StatusMessage.Success,
            Body = _localizer.Site["The site was successfully saved"]
        };
    }

    /// <summary>
    /// Deletes the site with the given id.
    /// </summary>
    /// <param name="id">The unique id</param>
    /// <returns>The result of the operation</returns>
    [Route("delete")]
    [HttpDelete]
    [Authorize(Policy = Permission.SitesDelete)]
    [SuppressMessage("Microsoft.Design", "CA1031", Justification = "Logging should catch all exceptions")]
    public async Task<StatusMessage> Delete([FromBody] Guid id)
    {
        try
        {
            await _service.Delete(id);
        }
        catch (ValidationException e)
        {
            // Validation did not succeed
            return new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = e.Message
            };
        }
        catch (Exception e)
        {
            _logger?.LogError("Save() {Message}", e.Message);

            return new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = _localizer.Site["An error occured while deleting the site"]
            };
        }

        return new StatusMessage
        {
            Type = StatusMessage.Success,
            Body = _localizer.Site["The site was successfully deleted"]
        };
    }
}
