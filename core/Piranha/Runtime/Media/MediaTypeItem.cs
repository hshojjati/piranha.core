/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

namespace Piranha.Runtime.Media;

/// <summary>
/// A registered media type.
/// </summary>
public class MediaTypeItem
{
    /// <summary>
    /// Gets/sets the file extension.
    /// </summary>
    public string Extension { get; set; }

    /// <summary>
    /// Gets/sets the content type.
    /// </summary>
    public string ContentType { get; set; }

    /// <summary>
    /// If image processing should be applied to this media type.
    /// </summary>
    public bool AllowProcessing { get; set; }
}
