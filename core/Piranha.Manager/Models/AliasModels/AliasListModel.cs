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
using System.Collections.Generic;

namespace Piranha.Manager.Models.AliasModels;

/// <summary>
/// Alias model.
/// </summary>
public sealed class AliasListModel
{
    /// <summary>
    /// Gets/sets the current site id.
    /// </summary>
    public Guid SiteId { get; set; }

    /// <summary>
    /// Gets/sets the current site title.
    /// </summary>
    public string SiteTitle { get; set; }

    /// <summary>
    /// Gets/sets the available sites.
    /// </summary>
    public IList<AliasListSiteItem> Sites { get; set; } = new List<AliasListSiteItem>();

    /// <summary>
    /// Gets/set the available items.
    /// </summary>
    public IList<AliasListItem> Items { get; set; } = new List<AliasListItem>();

    /// <summary>
    /// Gets/sets the optional status message from the last operation.
    /// </summary>
    public StatusMessage Status { get; set; }
}
