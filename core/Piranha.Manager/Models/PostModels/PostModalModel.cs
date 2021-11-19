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

namespace Piranha.Manager.Models.PostModels;

public sealed class PostModalModel
{
    public IEnumerable<PostModalSiteItem> Sites { get; set; } = new List<PostModalSiteItem>();
    public IEnumerable<PostModalArchiveItem> Archives { get; set; } = new List<PostModalArchiveItem>();
    public IEnumerable<PostModalItem> Posts { get; set; } = new List<PostModalItem>();

    public Guid SiteId { get; set; }
    public Guid ArchiveId { get; set; }

    public string SiteTitle { get; set; }
    public string ArchiveTitle { get; set; }
    public string ArchiveSlug { get; set; }
}
