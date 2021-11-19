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

namespace Piranha.Manager.Models.MediaModels;

/// <summary>
/// An item in the media list model.
/// </summary>
public sealed class MediaListItem
{
    /// <summary>
    /// Gets/sets the unique id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets/sets the optional folder id.
    /// </summary>
    public Guid? FolderId { get; set; }

    /// <summary>
    /// Gets/sets the media type.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets/sets the filename of the uploaded media.
    /// </summary>
    public string Filename { get; set; }

    /// <summary>
    /// Gets/sets the content type of the uploaded media.
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// Gets/sets the optional title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets/sets the optional alt text.
    /// </summary>
    public string AltText { get; set; }

    /// <summary>
    /// Gets/sets the optional description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets/sets the optional properties.
    /// </summary>
    public IList<KeyValuePair<string, string>> Properties { get; set; } = new List<KeyValuePair<string, string>>();

    /// <summary>
    /// Gets/sets the public url used to access the uploaded media.
    /// </summary>
    public string PublicUrl { get; set; }

    /// <summary>
    /// Gets/sets the file size.
    /// </summary>
    public string Size { get; set; }

    /// <summary>
    /// Gets/sets the optional width.
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Gets/sets the optional height.
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// An optional version url for a different size when requested via the list api call on the MediaApiController. Only use when expecting this call.
    /// </summary>
    public string AltVersionUrl { get; set; }

    /// <summary>
    /// Gets/sets the last modification date.
    /// </summary>
    public string LastModified { get; set; }
}
