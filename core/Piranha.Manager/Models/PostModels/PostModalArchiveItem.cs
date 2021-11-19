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

namespace Piranha.Manager.Models.PostModels;

/// <summary>
/// An archive item in the post modal.
/// </summary>
public sealed class PostModalArchiveItem
{
    /// <summary>
    /// Gets/sets the archive id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets/sets the title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets/sets the archive slug.
    /// </summary>
    public string Slug { get; set; }
}

