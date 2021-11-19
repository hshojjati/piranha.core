/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System.Collections.Generic;
using Piranha.Manager.Models.Content;

namespace Piranha.Manager.Models.PageModels;

/// <summary>
/// Page list model.
/// </summary>
public sealed class PageListModel
{
    /// <summary>
    /// Gets/sets the available sites.
    /// </summary>
    public IList<PageListSiteItem> Sites { get; set; } = new List<PageListSiteItem>();

    /// <summary>
    /// Gets/sets the available page types.
    /// </summary>
    public IList<ContentTypeModel> PageTypes { get; set; } = new List<ContentTypeModel>();

    /// <summary>
    /// Gets/sets the optional status message.
    /// </summary>
    public StatusMessage Status { get; set; }
}
