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

namespace Piranha.Manager.Models.ContentModels;

public sealed class ContentListItem
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string TypeId { get; set; }
    public string Modified { get; set; }
    public string Status { get; set; }
    public string EditUrl { get; set; }
}
