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
using System.Linq;

namespace Piranha.Runtime.Media;

/// <summary>
/// A list of media types.
/// </summary>
public class MediaTypeList : List<MediaTypeItem>
{
    private readonly bool _allowProcessing;

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="allowProcessing">If image processing should be applied by default</param>
    public MediaTypeList(bool allowProcessing = false)
    {
        _allowProcessing = allowProcessing;
    }

    /// <summary>
    /// Adds a new media type.
    /// </summary>
    /// <param name="extension">The file extension</param>
    /// <param name="contentType">The content type</param>
    /// <param name="allowProcessing">If image processing should be allowed</param>
    public void Add(string extension, string contentType, bool? allowProcessing = null)
    {
        Add(new MediaTypeItem
        {
            Extension = extension.ToLower(),
            ContentType = contentType,
            AllowProcessing = allowProcessing ?? _allowProcessing
        });
    }

    /// <summary>
    /// Gets if the list contains an item with the given extension.
    /// </summary>
    /// <param name="extension">The file extension</param>
    /// <returns>If the extension exists</returns>
    public bool ContainsExtension(string extension)
    {
        return this.Any(t => t.Extension.Equals(extension, System.StringComparison.OrdinalIgnoreCase));
    }
}
