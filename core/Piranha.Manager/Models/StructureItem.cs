﻿/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license. See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System.Collections.Generic;

namespace Piranha.Manager.Models;

public sealed class StructureItem
{
    /// <summary>
    /// Gets/sets the unique page id.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets/sets the available children.
    /// </summary>
    public IList<StructureItem> Children { get; set; }

    /// <summary>
    /// Default constructor.
    /// </summary>
    public StructureItem()
    {
        Children = new List<StructureItem>();
    }
}
