﻿/*
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

namespace Piranha.Manager.Models.PageModels;

public sealed class PageListItem
{
    public static readonly string Draft = "Draft";
    public static readonly string Unpublished = "Unpublished";

    public Guid Id { get; set; }
    public Guid SiteId { get; set; }
    public string Title { get; set; }
    public string TypeName { get; set; }
    public string Published { get; set; }
    public string Status { get; set; }
    public string EditUrl { get; set; }
    public bool IsCopy { get; set; }
    public bool IsDraft { get; set; }
    public bool IsExpanded { get; set; }
    public bool IsRestricted { get; set; }
    public bool IsScheduled { get; set; }
    public bool IsUnpublished { get; set; }
    public string Permalink { get; set; }
    public IList<PageListItem> Items { get; set; } = new List<PageListItem>();
}
