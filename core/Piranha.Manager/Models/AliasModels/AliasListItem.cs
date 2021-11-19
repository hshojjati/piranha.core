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

namespace Piranha.Manager.Models.AliasModels;

/// <summary>
/// An item in the alias list model.
/// </summary>
public sealed class AliasListItem
{
    /// <summary>
    /// Gets/sets the optional id.
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets/sets the site id.
    /// </summary>
    public Guid SiteId { get; set; }

    /// <summary>
    /// Gets/sets the alias url.
    /// </summary>
    public string AliasUrl { get; set; }

    /// <summary>
    /// Gets/sets the redirect url.
    /// </summary>
    public string RedirectUrl { get; set; }

    /// <summary>
    /// Gets/sets if the redirect should be permanent.
    /// </summary>
    public bool IsPermanent { get; set; }
}
