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
/// A site item in the post modal model.
/// </summary>
public sealed class PostModalSiteItem
{
    /// <summary>
    /// Gets/sets the site id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets/sets the site title.
    /// </summary>
    public string Title { get; set; }
}

