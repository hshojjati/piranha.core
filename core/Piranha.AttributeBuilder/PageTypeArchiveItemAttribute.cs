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
using System.Diagnostics.CodeAnalysis;

namespace Piranha.AttributeBuilder;

/// <summary>
/// Attribute for adding a route to a page type.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
[SuppressMessage("Microsoft.Design", "CA1019", Justification = "Public API")]
public class PageTypeArchiveItemAttribute : Attribute
{
    /// <summary>
    /// Gets/sets the allowed post type.
    /// </summary>
    public Type PostType { get; set; }

    /// <summary>
    /// Default constructor.
    /// </summary>
    /// <param name="type">The allowed post type</param>
    public PageTypeArchiveItemAttribute(Type type)
    {
        PostType = type;
    }
}
