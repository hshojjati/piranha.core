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
using System.IO;
using System.Linq;
using Piranha.Models;
using Piranha.Runtime.Media;

namespace Piranha.Runtime;

public class MediaManager
{
    /// <summary>
    /// Gets/sets the currently accepted document extensions.
    /// </summary>
    public MediaTypeList Documents { get; set; } = new MediaTypeList();

    /// <summary>
    /// Gets/sets the currently accepted image extensions.
    /// </summary>
    public MediaTypeList Images { get; set; } = new MediaTypeList(true);

    /// <summary>
    /// Gets/sets the currently accepted video extensions.
    /// </summary>
    public MediaTypeList Videos { get; set; } = new MediaTypeList();

    /// <summary>
    /// Gets/sets the currently accepted audio extensions.
    /// </summary>
    public MediaTypeList Audio { get; set; } = new MediaTypeList();

    /// <summary>
    /// Gets/sets the currently accepted resource extensions.
    /// </summary>
    public MediaTypeList Resources { get; set; } = new MediaTypeList();

    /// <summary>
    /// Gets/sets the currently registered meta properties for media.
    /// </summary>
    public IList<string> MetaProperties { get; set; } = new List<string>();

    /// <summary>
    /// Checks if the given filename has a supported extension.
    /// </summary>
    /// <param name="filename">The path or filename</param>
    /// <returns>If it is supported</returns>
    public bool IsSupported(string filename)
    {
        var extension = Path.GetExtension(filename);

        return Documents.ContainsExtension(extension) ||
            Images.ContainsExtension(extension) ||
            Videos.ContainsExtension(extension) ||
            Audio.ContainsExtension(extension) ||
            Resources.ContainsExtension(extension);
    }

    /// <summary>
    /// Gets the media type for the given filename based on
    /// its extension.
    /// </summary>
    /// <param name="filename">The path or filename</param>
    /// <returns>The media type</returns>
    public MediaType GetMediaType(string filename)
    {
        var extension = Path.GetExtension(filename);

        if (Documents.ContainsExtension(extension))
        {
            return MediaType.Document;
        }
        if (Images.ContainsExtension(extension))
        {
            return MediaType.Image;
        }
        if (Videos.ContainsExtension(extension))
        {
            return MediaType.Video;
        }
        if (Audio.ContainsExtension(extension))
        {
            return MediaType.Audio;
        }
        if (Resources.ContainsExtension(extension))
        {
            return MediaType.Resource;
        }
        return MediaType.Unknown;
    }

    /// <summary>
    /// Gets the content type for the given filename based on
    /// its extension.
    /// </summary>
    /// <param name="filename">The path or filename</param>
    /// <returns>The media type</returns>
    public string GetContentType(string filename)
    {
        var extension = Path.GetExtension(filename).ToLower();
        MediaTypeItem item = null;

        if ((item = Documents.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item.ContentType;
        }
        if ((item = Images.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item.ContentType;
        }
        if ((item = Videos.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item.ContentType;
        }
        if ((item = Audio.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item.ContentType;
        }
        if ((item = Resources.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item.ContentType;
        }
        return "application/octet-stream";
    }

    /// <summary>
    /// Gets the media type item for the given filename based on its extensions.
    /// </summary>
    /// <param name="filename">The path or filename</param>
    /// <returns>The media type item</returns>
    public MediaTypeItem GetItem(string filename)
    {
        var extension = Path.GetExtension(filename).ToLower();
        MediaTypeItem item = null;

        if ((item = Documents.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item;
        }
        if ((item = Images.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item;
        }
        if ((item = Videos.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item;
        }
        if ((item = Audio.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item;
        }
        if ((item = Resources.SingleOrDefault(t => t.Extension == extension)) != null)
        {
            return item;
        }
        return null;
    }
}
