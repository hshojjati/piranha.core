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
/// Model for a media folder.
/// </summary>
public sealed class MediaFolderModel
{
    /// <summary>
    /// Gets/sets the optional id.
    /// </summary>
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets/sets the optional parent id.
    /// </summary>
    public Guid? ParentId { get; set; }

    /// <summary>
    /// Gets/sets the name.
    /// </summary>
    public string Name { get; set; }
}
