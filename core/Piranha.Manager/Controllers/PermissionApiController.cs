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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Piranha.Manager.Models;

namespace Piranha.Manager.Controllers;

/// <summary>
/// Api controller for getting user permissions.
/// </summary>
[Area("Manager")]
[Route("manager/api/permissions")]
[Authorize(Policy = Permission.Admin)]
[ApiController]
[AutoValidateAntiforgeryToken]
public class PermissionApiController : Controller
{
    private readonly IAuthorizationService _auth;

    /// <summary>
    /// Default constructor.
    /// </summary>
    public PermissionApiController(IAuthorizationService auth)
    {
        _auth = auth;
    }

    [HttpGet]
    [Authorize(Policy = Permission.Admin)]
    public async Task<ClientPermissions> Get()
    {
        var model = new ClientPermissions();

        // Alias permissions
        model.Aliases[ClientPermissions.Edit] = (await _auth.AuthorizeAsync(User, Permission.AliasesEdit)).Succeeded;
        model.Aliases[ClientPermissions.Delete] = (await _auth.AuthorizeAsync(User, Permission.AliasesDelete)).Succeeded;

        // Comment permissions
        model.Comments[ClientPermissions.Approve] = (await _auth.AuthorizeAsync(User, Permission.CommentsApprove)).Succeeded;
        model.Comments[ClientPermissions.Delete] = (await _auth.AuthorizeAsync(User, Permission.CommentsDelete)).Succeeded;

        // Media permissions
        model.Media[ClientPermissions.Add] = (await _auth.AuthorizeAsync(User, Permission.MediaAdd)).Succeeded;
        model.Media[ClientPermissions.AddFolder] = (await _auth.AuthorizeAsync(User, Permission.MediaAddFolder)).Succeeded;
        model.Media[ClientPermissions.Delete] = (await _auth.AuthorizeAsync(User, Permission.MediaDelete)).Succeeded;
        model.Media[ClientPermissions.DeleteFolder] = (await _auth.AuthorizeAsync(User, Permission.MediaDeleteFolder)).Succeeded;
        model.Media[ClientPermissions.Edit] = (await _auth.AuthorizeAsync(User, Permission.MediaEdit)).Succeeded;

        // Page permissions
        model.Pages[ClientPermissions.Add] = (await _auth.AuthorizeAsync(User, Permission.PagesAdd)).Succeeded;
        model.Pages[ClientPermissions.Delete] = (await _auth.AuthorizeAsync(User, Permission.PagesDelete)).Succeeded;
        model.Pages[ClientPermissions.Edit] = (await _auth.AuthorizeAsync(User, Permission.PagesEdit)).Succeeded;
        model.Pages[ClientPermissions.Preview] = (await _auth.AuthorizeAsync(User, Security.Permission.PagePreview)).Succeeded;
        model.Pages[ClientPermissions.Publish] = (await _auth.AuthorizeAsync(User, Permission.PagesPublish)).Succeeded;
        model.Pages[ClientPermissions.Save] = (await _auth.AuthorizeAsync(User, Permission.PagesSave)).Succeeded;

        // Post permissions
        model.Posts[ClientPermissions.Add] = (await _auth.AuthorizeAsync(User, Permission.PostsAdd)).Succeeded;
        model.Posts[ClientPermissions.Delete] = (await _auth.AuthorizeAsync(User, Permission.PostsDelete)).Succeeded;
        model.Posts[ClientPermissions.Edit] = (await _auth.AuthorizeAsync(User, Permission.PostsEdit)).Succeeded;
        model.Posts[ClientPermissions.Preview] = (await _auth.AuthorizeAsync(User, Security.Permission.PostPreview)).Succeeded;
        model.Posts[ClientPermissions.Publish] = (await _auth.AuthorizeAsync(User, Permission.PostsPublish)).Succeeded;
        model.Posts[ClientPermissions.Save] = (await _auth.AuthorizeAsync(User, Permission.PostsSave)).Succeeded;

        // Site permissions
        model.Sites[ClientPermissions.Add] = (await _auth.AuthorizeAsync(User, Permission.SitesAdd)).Succeeded;
        model.Sites[ClientPermissions.Delete] = (await _auth.AuthorizeAsync(User, Permission.SitesDelete)).Succeeded;
        model.Sites[ClientPermissions.Edit] = (await _auth.AuthorizeAsync(User, Permission.SitesEdit)).Succeeded;
        model.Sites[ClientPermissions.Save] = (await _auth.AuthorizeAsync(User, Permission.SitesSave)).Succeeded;

        return model;
    }
}
