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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piranha.Manager.Models.PostModels;

/// <summary>
/// An item in the post modal model.
/// </summary>
public sealed class PostModalItem
{
    /// <summary>
    /// Gets/sets the unique id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets/sets the title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets/sets the permalink.
    /// </summary>
    public string Permalink { get; set; }

    /// <summary>
    /// Gets/sets the published date formatted as a string.
    /// </summary>
    public string Published { get; set; }
}
