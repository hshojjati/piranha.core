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

namespace Piranha.Manager.Models.MediaModels;

/// <summary>
/// A folder item in the media list view.
/// </summary>
public sealed class MediaListFolderItem
{
    /// <summary>
    /// Gets/sets the unique id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets/sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets/sets the item count in the folder.
    /// </summary>
    public int ItemCount { get; set; }
}
