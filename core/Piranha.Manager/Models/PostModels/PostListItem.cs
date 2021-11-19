/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

namespace Piranha.Manager.Models.PostModels;

public sealed class PostListItem
{
    public static readonly string Draft = "Draft";
    public static readonly string Unpublished = "Unpublished";

    public string Id { get; set; }
    public string Title { get; set; }
    public string TypeName { get; set; }
    public string Category { get; set; }
    public string Published { get; set; }
    public string Status { get; set; }
    public string EditUrl { get; set; }
    public bool isScheduled { get; set; }
}
