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
using Piranha.Models;

namespace Piranha.Manager.Models.MediaModels;

/// <summary>
/// List model for the media view.
/// </summary>
public sealed class MediaListModel
{
    public static string ListView { get; } = "list";
    public static string GalleryView { get; } = "gallery";

    /// <summary>
    /// Gets/sets the available folders.
    /// </summary>
    public IList<MediaListFolderItem> Folders { get; set; } = new List<MediaListFolderItem>();

    /// <summary>
    /// Gets/sets the available media items.
    /// </summary>
    public IList<MediaListItem> Media { get; set; } = new List<MediaListItem>();

    /// <summary>
    /// Gets/sets the optional folder id.
    /// </summary>
    public Guid? CurrentFolderId { get; set; }

    /// <summary>
    /// Gets/sets the optional folder name
    /// </summary>
    public string CurrentFolderName { get; set; }

    /// <summary>
    /// Gets/sets the optional parent id.
    /// </summary>
    public Guid? ParentFolderId { get; set; }

    /// <summary>
    /// Gets/sets if the current folder can be deleted.
    /// </summary>
    public bool CanDelete { get; set; }

    /// <summary>
    /// Gets/sets the optional status message from the last operation.
    /// </summary>
    public StatusMessage Status { get; set; }

    /// <summary>
    /// Gets/sets the recommended view mode for the folder.
    /// </summary>
    public string ViewMode { get; set; }

    /// <summary>
    /// Gets/sets the media folder structure.
    /// </summary>
    public MediaStructure Structure { get; set; }

    /// <summary>
    /// Gets/sets the media folder structure.
    /// </summary>
    public IList<MediaFolderSimple> CurrentFolderBreadcrumb { get; set; }

    /// <summary>
    /// Gets/sets the amount of media files at root level.
    /// </summary>
    public int RootCount { get; set; }

    /// <summary>
    /// Gets/sets the total amount of media files.
    /// </summary>
    public int TotalCount { get; set; }
}
