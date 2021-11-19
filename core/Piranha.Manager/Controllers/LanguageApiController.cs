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
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Piranha.Manager.Models;
using Piranha.Manager.Models.LanguageModels;
using Piranha.Manager.Services;

namespace Piranha.Manager.Controllers;

/// <summary>
/// Api controller for language management.
/// </summary>
[Area("Manager")]
[Route("manager/api/language")]
[Authorize(Policy = Permission.Admin)]
[ApiController]
[AutoValidateAntiforgeryToken]
public class LanguageApiController : Controller
{
    private readonly LanguageService _service;
    private readonly ManagerLocalizer _localizer;
    private readonly ILogger _logger;

    /// <summary>
    /// Default constructor.
    /// </summary>
    public LanguageApiController(LanguageService service, ManagerLocalizer localizer, ILoggerFactory factory = null)
    {
        _service = service;
        _localizer = localizer;
        _logger = factory?.CreateLogger<LanguageApiController>();
    }

    /// <summary>
    /// Gets the edit model.
    /// </summary>
    /// <returns>The edit model</returns>
    [Route("")]
    [HttpGet]
    public async Task<LanguageEditModel> Get()
    {
        return await _service.Get();
    }

    /// <summary>
    /// Saves the edit model.
    /// </summary>
    /// <param name="model">The model</param>
    [Route("")]
    [HttpPost]
    [SuppressMessage("Microsoft.Design", "CA1031", Justification = "Logging should catch all exceptions")]
    public async Task<IActionResult> Save(LanguageEditModel model)
    {
        try
        {
            var result = await _service.Save(model);

            result.Status = new StatusMessage
            {
                Type = StatusMessage.Success,
                Body = _localizer.Language["The language was successfully saved"]
            };

            return Ok(result);
        }
        catch (Exception e)
        {
            _logger?.LogError("Save() {Message}", e.Message);

            var result = new LanguageEditModel();
            result.Status = new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = e.Message
            };
            return BadRequest(result);
        }
    }

    /// <summary>
    /// Deletes the language with the given id.
    /// </summary>
    /// <param name="id">The unique id</param>
    [Route("{id}")]
    [HttpDelete]
    [SuppressMessage("Microsoft.Design", "CA1031", Justification = "Logging should catch all exceptions")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            var result = await _service.Delete(id);

            result.Status = new StatusMessage
            {
                Type = StatusMessage.Success,
                Body = _localizer.Language["The language was successfully deleted"]
            };

            return Ok(result);
        }
        catch (Exception e)
        {
            _logger?.LogError("Delete() {Message}", e.Message);

            var result = new LanguageEditModel();
            result.Status = new StatusMessage
            {
                Type = StatusMessage.Error,
                Body = e.Message
            };
            return BadRequest(result);
        }
    }
}
